using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class DatabaseUpdate
    {
        public static bool UpdateReservation(int idRezervacije, int idVozila, int idKlijenta, DateTime datumVremePocetka, int brojDana, int brojSati)
        {
            DateTime datumVremeKraja = GetReservationData.EndOfReservationDate(datumVremePocetka, brojDana, brojSati);
            int cena = int.Parse(Calculator.ReservationPrice(idVozila, brojDana, brojSati).ToString());

            if (!DatabaseContains.AvailableVehicle(idVozila, datumVremePocetka, datumVremeKraja, idRezervacije))
            {
                MessageBox.Show("Vozilo nije dostupno u tom periodu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (DatabaseContains.ClientWithReservationOverlap(idKlijenta, datumVremePocetka, datumVremeKraja, idRezervacije))
                return false;
           
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "UPDATE Rezervacija " +
                                  "SET id_vozila = ?, " +
                                  "    id_klijenta = ?, " +
                                  "    datumVreme_pocetka = ?, " +
                                  "    datumVreme_kraja = ?, " +
                                  "    cena = ? " +
                                  "WHERE id_rezervacija = ?";
                    
                    using (OleDbCommand cmd = new OleDbCommand(upit, con))
                    {
                        cmd.Parameters.AddWithValue("@id_vozila", idVozila);
                        cmd.Parameters.AddWithValue("@id_klijenta", idKlijenta);
                        cmd.Parameters.AddWithValue("@datumVreme_pocetka", datumVremePocetka);
                        cmd.Parameters.AddWithValue("@datumVreme_kraja", datumVremeKraja);
                        cmd.Parameters.AddWithValue("@cena", cena);
                        cmd.Parameters.AddWithValue("@id_rezervacija", idRezervacije);

                        con.Open();
                        int azuriraniRedovi = cmd.ExecuteNonQuery();
                        return azuriraniRedovi > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"UpdateException {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
