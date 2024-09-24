using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class GetFilteredTable
    {
        public static DataTable FilteredVehiclesTableByCategory(DataTable trenutnaTabela, int idKategorije)
        {
            DataTable filtriranaVozila = new DataTable();
            try
            {
                DataSetRefresh.RefreshVehicleTable();

                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit;
                    if (idKategorije < 1)
                        upit = "SELECT * FROM Vozilo";
                    else
                        upit = "SELECT * FROM Vozilo WHERE id_kategorije = @idKategorije";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, con))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@idKategorije", idKategorije);
                        con.Open();
                        adapter.Fill(filtriranaVozila);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return filtriranaVozila;
        }
        public static DataTable FilteredTableByAvailableVehicles(DateTime pocetak, DateTime kraj)
        {
            DataTable svaVozila = DatabaseRead.VehicleTable();
            DataTable dostupnaVozila = svaVozila.Clone();

            foreach (DataRow voziloRow in svaVozila.Rows)
            {
                int idVozila = Convert.ToInt32(voziloRow["id_vozila"]);

                bool dostupno = DatabaseContains.AvailableVehicle(idVozila, pocetak, kraj);

                if (dostupno)
                    dostupnaVozila.ImportRow(voziloRow);
            }
            return dostupnaVozila;
        }
        public static DataTable FilteredTableByPrice(double trenutnaCena)
        {
            DataTable filtriranaTabela = new DataTable();
            try
            {
                DataSetRefresh.RefreshVehicleTable();

                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "SELECT * FROM Vozilo WHERE cena_po_satu BETWEEN 0 AND @cenaPoSatu";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, con))
                    {
                        con.Open();
                        adapter.SelectCommand.Parameters.AddWithValue("@cenaPoSatu", trenutnaCena);
                        adapter.Fill(filtriranaTabela);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return filtriranaTabela;
        }
    }
}
