using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class Calculator
    {
        public static double MaxPrice()
        {
            double maxCena = 0;
            try
            {
                DataSetRefresh.RefreshVehicleTable();
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "SELECT MAX(cena_po_satu) FROM Vozilo";
                    using (OleDbCommand cmd = new OleDbCommand(upit, con))
                    {
                        con.Open();
                        maxCena = Double.Parse(cmd.ExecuteScalar().ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return maxCena;
        }
        public static double ReservationPrice(int id_vozila, int brojDana, int brojSati)
        {
            double cenaPoSatu = GetVehicleData.HourlyRateFor(id_vozila);
            int ukupanBrojSati = brojDana * 24 + brojSati;
            double ukupnaCena = cenaPoSatu * ukupanBrojSati;

            return Math.Round(ukupnaCena);
        }
        public static double RemainingTimeUntilReservationStart(int idRezervacije)
        {
            double brojSati = 0;
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "SELECT datumVreme_pocetka FROM Rezervacija WHERE id_rezervacije = @id_rezervacije";

                    using (OleDbCommand cmd = new OleDbCommand(upit, con))
                    {
                        cmd.Parameters.AddWithValue("@id_rezervacije", idRezervacije);
                        con.Open();

                        DateTime datumVremePocetka = (DateTime)cmd.ExecuteScalar();
                        brojSati = (datumVremePocetka - DateTime.Now).TotalHours;

                        //if (brojSati < 0)
                        //{
                        //    MessageBox.Show("Rezervacija je već u toku.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    return 0;
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ValidatorException {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return brojSati;
        }

    }
}
