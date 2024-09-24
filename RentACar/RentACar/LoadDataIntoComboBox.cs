using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class LoadDataIntoComboBox
    {
        public static void LoadCategoriesIntoComboBoxWithALlOption(ComboBox cmb)
        {
            DataSetRefresh.RefreshCategoryTable();
            DataTable kategorijeSaSvima = GetCategoryData.CategoriesWithAllOption();

            cmb.DisplayMember = "naziv";
            cmb.ValueMember = "id_kategorije";
            cmb.DataSource = kategorijeSaSvima;
        }
        public static void LoadCategoriesIntoComboBox(ComboBox cmb)
        {
            DataSetRefresh.RefreshCategoryTable();
            cmb.DisplayMember = "naziv";
            cmb.ValueMember = "id_kategorije";
            cmb.DataSource = DataSetManager.DS1.Kategorija;
        }
        public static void LoadVehiclesIntoComboBoxBrandAndModel(ComboBox cmb)
        {
            DataSetRefresh.RefreshVehicleTable();

            DataTable vozila = DataSetManager.DS1.Vozilo.Copy();

            if (!vozila.Columns.Contains("markaIModel"))
            {
                vozila.Columns.Add("markaIModel", typeof(string));
            }

            foreach (DataRow row in vozila.Rows)
            {
                row["markaIModel"] = row["marka"] + " " + row["model"];
            }

            cmb.DisplayMember = "markaIModel";
            cmb.ValueMember = "id_vozila";
            cmb.DataSource = vozila;

        }
        public static void LoadUsersIntoComboBox(ComboBox cmb)
        {
            DataSetRefresh.RefreshUserTable();
            cmb.DisplayMember = "ime";
            cmb.ValueMember = "id_klijenta";
            cmb.DataSource = DataSetManager.DS1.Klijent;
        }

    }
}
