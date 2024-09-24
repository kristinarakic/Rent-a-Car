using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class LoadTablesIntoGridView
    {
        public static void LoadCategoryTable(DataGridView tabela)
        {
            DataSetManager.DS1.Kategorija.Clear();
            DataSetRefresh.RefreshCategoryTable();
            tabela.DataSource = DataSetManager.DS1.Kategorija;
        }
        public static void LoadUserTable(DataGridView tabela)
        {
            DataSetManager.DS1.Klijent.Clear();
            DataSetRefresh.RefreshUserTable();
            tabela.DataSource = DataSetManager.DS1.Klijent;
        }
        public static void LoadVehicleTable(DataGridView tabela)
        {
            DataSetManager.DS1.Vozilo.Clear();
            DataSetRefresh.RefreshVehicleTable();
            tabela.DataSource = DataSetManager.DS1.Vozilo;
        }
        public static void LoadReservationTable(DataGridView tabela)
        {
            DataSetManager.DS1.Rezervacija.Clear();
            DataSetRefresh.RefreshReservationTable();
            tabela.DataSource = DataSetManager.DS1.Rezervacija;
        }

    }
}
