using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class DataSetRefresh
    {
        public static void RefreshVehicleTable()
        {
            using (OleDbConnection connection = new OleDbConnection(DataSetManager.ConString))
            {
                string upit = "SELECT * FROM Vozilo";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, connection))
                {
                    DataSetManager.DS1.Vozilo.Clear();
                    adapter.Fill(DataSetManager.DS1.Vozilo);
                }
            }
        }
        public static void RefreshUserTable()
        {
            using (OleDbConnection connection = new OleDbConnection(DataSetManager.ConString))
            {
                string upit = "SELECT * FROM Klijent";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, connection))
                {
                    DataSetManager.DS1.Klijent.Clear();
                    adapter.Fill(DataSetManager.DS1.Klijent);
                }
            }
        }
        public static void RefreshCategoryTable()
        {
            using (OleDbConnection connection = new OleDbConnection(DataSetManager.ConString))
            {
                string upit = "SELECT * FROM Kategorija";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, connection))
                {
                    DataSetManager.DS1.Kategorija.Clear();
                    adapter.Fill(DataSetManager.DS1.Kategorija);
                }
            }
        }
        public static void RefreshReservationTable()
        {
            using (OleDbConnection connection = new OleDbConnection(DataSetManager.ConString))
            {
                string upit = "SELECT * FROM Rezervacija";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, connection))
                {
                    DataSetManager.DS1.Rezervacija.Clear();
                    adapter.Fill(DataSetManager.DS1.Rezervacija);
                }
            }
        }
    }
}
