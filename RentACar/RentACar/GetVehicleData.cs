using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class GetVehicleData
    {
        public static double HourlyRateFor(int id_vozila)
        {
            double cenaPoSatu = 0;
            try
            {
                DataSetRefresh.RefreshVehicleTable();
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "SELECT cena_po_satu FROM Vozilo WHERE id_vozila = @idVozila";
                    using (OleDbCommand cmd = new OleDbCommand(upit, con))
                    {
                        cmd.Parameters.AddWithValue("@idVozila", id_vozila);
                        con.Open();
                        cenaPoSatu = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return cenaPoSatu;
        }
        public static string MostPopularVehicleName()
        {
            string imeVozila = null;
            string upit = @"
                    SELECT TOP 1 v.[marka] & ' ' & v.[model] AS imeVozila
                    FROM [Rezervacija] r
                    INNER JOIN [Vozilo] v ON r.[id_vozila] = v.[id_vozila]
                    GROUP BY v.[marka], v.[model]
                    ORDER BY COUNT(r.[id_vozila]) DESC";

            using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
            {
                try
                {
                    OleDbCommand command = new OleDbCommand(upit, con);
                    con.Open();

                    object vracenObjekat = command.ExecuteScalar();

                    if (vracenObjekat != null)
                    {
                        imeVozila = vracenObjekat.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

            return imeVozila;
        }

    }
}
