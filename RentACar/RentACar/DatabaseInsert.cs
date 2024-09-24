using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.IO.MemoryMappedFiles;

namespace RentACar
{
    internal class DatabaseInsert
    {
        public static bool InsertVehicle(int idKategorija, string ime, string marka, string model, int godina, double cena)
        {
            if (!DatabaseContains.Vehicle(idKategorija, ime, marka, model, godina, cena))
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                    {
                        string insertQuery = "INSERT INTO Vozilo (id_kategorije, naziv, marka, model, godina_proizvodnje, cena_po_satu)" +
                            " VALUES (@id_kategorije, @naziv, @marka, @model, @godina_proizvodnje, @cena_po_satu)";

                        using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@idKategorije", idKategorija);
                            cmd.Parameters.AddWithValue("@ime", ime);
                            cmd.Parameters.AddWithValue("@marka", marka);
                            cmd.Parameters.AddWithValue("@model", model);
                            cmd.Parameters.AddWithValue("@godina", godina);
                            cmd.Parameters.AddWithValue("@cena", cena);

                            con.Open();
                            int azuriraniRedovi = cmd.ExecuteNonQuery();
                            return azuriraniRedovi > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool InsertCategory(string ime, string opis)
        {
            if (!DatabaseContains.Category(ime, opis))
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                    {
                        string insertQuery = "INSERT INTO Kategorija (naziv, opis) VALUES (@naziv, @opis)";

                        using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@naziv", ime);
                            cmd.Parameters.AddWithValue("@opis", opis);

                            con.Open();
                            int azuriraniRedovi = cmd.ExecuteNonQuery();

                            if (azuriraniRedovi > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kateogrija {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool InsertUser(string ime, string prezime, string adresa, string telefon, string vozacka)
        {
            if (!DatabaseContains.User(ime, prezime, adresa, telefon, vozacka))
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                    {
                        string insertQuery = "INSERT INTO Klijent (ime, prezime, adresa, telefon, vozacka_kategorija)" +
                            " VALUES (@ime, @prezime, @adresa, @telefon, @vozacka)";

                        using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@ime", ime);
                            cmd.Parameters.AddWithValue("@prezime", prezime);
                            cmd.Parameters.AddWithValue("@adresa", adresa);
                            cmd.Parameters.AddWithValue("@telefon", telefon);
                            cmd.Parameters.AddWithValue("@vozacka", vozacka);

                            con.Open();
                            int azuriraniRedovi = cmd.ExecuteNonQuery();
                            return azuriraniRedovi > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool InsertReservation(int idVozila, int idKlijenta, DateTime datumVremePocetka, int brojDana, int brojSati)
        {
            DateTime datumVremeKraja = GetReservationData.EndOfReservationDate(datumVremePocetka, brojDana, brojSati);
            int cena = int.Parse(Calculator.ReservationPrice(idVozila, brojDana, brojSati).ToString());

            if (!DatabaseContains.AvailableVehicle(idVozila, datumVremePocetka, datumVremeKraja))
            {
                MessageBox.Show("Vozilo nije dostupno u tom periodu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (DatabaseContains.ClientWithReservationOverlap(idKlijenta, datumVremePocetka, datumVremeKraja))
                return false;

            try
            {
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "INSERT INTO Rezervacija (id_vozila, id_klijenta, datumVreme_pocetka, datumVreme_kraja, cena) " +
                                  "VALUES (@id_voz, @id_klijenta, @datumVreme_pocetka, @datumVreme_kraja, @cena)";

                    using (OleDbCommand cmd = new OleDbCommand(upit, con))
                    {
                        cmd.Parameters.AddWithValue("@id_voz", idVozila);
                        cmd.Parameters.AddWithValue("@id_klijenta", idKlijenta);
                        cmd.Parameters.AddWithValue("@datumVreme_pocetka", datumVremePocetka);
                        cmd.Parameters.AddWithValue("@datumVreme_kraja", datumVremeKraja);
                        cmd.Parameters.AddWithValue("@cena", cena);

                        con.Open();
                        int azuriraniRedovi = cmd.ExecuteNonQuery();
                        return azuriraniRedovi > 0;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"InsertException {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
