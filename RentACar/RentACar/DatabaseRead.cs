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
    internal class DatabaseRead
    {
        public static DataTable ReservationTable()
        {
            DataSetRefresh.RefreshReservationTable();
            DataTable rezervacije = new DataTable();
            try
            {
                DataSetRefresh.RefreshVehicleTable();

                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "SELECT * FROM Rezervacija";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, con))
                    {
                        adapter.Fill(rezervacije);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return rezervacije;
        }
        public static DataTable VehicleTable()
        {
            DataSetRefresh.RefreshReservationTable();
            DataTable vozila = new DataTable();
            try
            {
                DataSetRefresh.RefreshVehicleTable();

                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "SELECT * FROM Vozilo";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, con))
                    {
                        adapter.Fill(vozila);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return vozila;
        }
    }
}
