using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RentACar
{
    internal class DatabaseContains
    {
        public static bool Vehicle(int idKategorija, string ime, string marka, string model, int godina, double cena)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string checkQuery = "SELECT COUNT(*) FROM Vozilo WHERE naziv = @ime AND marka = @marka AND model = @model AND godina_proizvodnje = @godina";

                    using (OleDbCommand cmd = new OleDbCommand(checkQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@ime", ime);
                        cmd.Parameters.AddWithValue("@marka", marka);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@godina", godina);

                        con.Open();
                        int count = int.Parse(cmd.ExecuteScalar().ToString()); 

                        if (count > 0)
                        {
                            MessageBox.Show("Vozilo već postoji u bazi podataka.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public static bool Category(string ime, string opis)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "SELECT COUNT(*) FROM Kategorija WHERE naziv = @ime AND opis = @opis";

                    using (OleDbCommand cmd = new OleDbCommand(upit, con))
                    {
                        cmd.Parameters.AddWithValue("@ime", ime);
                        cmd.Parameters.AddWithValue("@opis", opis);

                        con.Open();
                        int count = int.Parse(cmd.ExecuteScalar().ToString());

                        if (count > 0)
                        {
                            MessageBox.Show("Kategorija već postoji u bazi podataka.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Category exception: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public static bool User(string ime, string prezime, string adresa, string telefon, string vozacka)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "SELECT COUNT(*) FROM Klijent WHERE ime = @ime AND prezime = @prezime AND adresa = @adresa AND telefon = @telefon AND vozacka_kategorija = @vozacka";

                    using (OleDbCommand cmd = new OleDbCommand(upit, con))
                    {
                        cmd.Parameters.AddWithValue("@ime", ime);
                        cmd.Parameters.AddWithValue("@prezime", prezime);
                        cmd.Parameters.AddWithValue("@adresa", adresa);
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        cmd.Parameters.AddWithValue("@vozacka", vozacka);

                        con.Open();
                        int count = int.Parse(cmd.ExecuteScalar().ToString());

                        if (count > 0)
                        {
                            MessageBox.Show("Klijent već postoji u bazi podataka.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public static bool AvailableVehicle(int idVozila, DateTime datumVremePocetka, DateTime datumVremeKraja, int? idRezervacijeZaPreskok = null)
        {
            DataSetRefresh.RefreshReservationTable();

            DataTable rezervacije = DatabaseRead.ReservationTable();

            foreach (DataRow row in rezervacije.Rows)
            {
                int id_vozila = Convert.ToInt32(row["id_vozila"]);
                int id_rezervacije = Convert.ToInt32(row["id_rezervacija"]);
                DateTime datumVremePocetkaPostojeca = Convert.ToDateTime(row["datumVreme_pocetka"]);
                DateTime datumVremeKrajaPostojeca = Convert.ToDateTime(row["datumVreme_kraja"]);

                if (idRezervacijeZaPreskok.HasValue && id_rezervacije == idRezervacijeZaPreskok)
                    continue;

                if (idVozila == id_vozila)
                {
                    bool preklapanje = GetReservationData.ConditionForReservationOverlap(datumVremePocetkaPostojeca, datumVremeKrajaPostojeca, datumVremePocetka, datumVremeKraja);

                    if (preklapanje) 
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool ClientWithReservationOverlap(int idKlijenta, DateTime datumVremePocetka, DateTime datumVremeKraja, int? idRezervacijeZaPreskok = null)
        {
            DataSetRefresh.RefreshReservationTable();
            DataTable rezervacije = DatabaseRead.ReservationTable();

            foreach (DataRow row in rezervacije.Rows)
            {
                int id_klijenta = Convert.ToInt32(row["id_klijenta"]);
                int id_rezervacije = Convert.ToInt32(row["id_rezervacija"]);
                DateTime datumVremePocetkaPostojeca = Convert.ToDateTime(row["datumVreme_pocetka"]);
                DateTime datumVremeKrajaPostojeca = Convert.ToDateTime(row["datumVreme_kraja"]);

                if (idRezervacijeZaPreskok.HasValue && id_rezervacije == idRezervacijeZaPreskok.Value)
                    continue;

                if (idKlijenta == id_klijenta)
                {
                    bool preklapanje = GetReservationData.ConditionForReservationOverlap(datumVremePocetkaPostojeca, datumVremeKrajaPostojeca, datumVremePocetka, datumVremeKraja);

                    if (preklapanje)
                    {
                        MessageBox.Show("Korisnik već ima rezervaciju u tom periodu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                }
            }
            return false;
        }
   
    }
}