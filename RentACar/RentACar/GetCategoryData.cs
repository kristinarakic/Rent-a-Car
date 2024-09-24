using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class GetCategoryData
    {
        public static DataTable CategoriesWithAllOption()
        {
            DataSetRefresh.RefreshCategoryTable();

            DataTable kategorijeSaSvima = DataSetManager.DS1.Kategorija.Clone();

            DataRow sveKategorijeRow = kategorijeSaSvima.NewRow();
            sveKategorijeRow["naziv"] = "Sve kategorije";
            sveKategorijeRow["id_kategorije"] = 0;
            kategorijeSaSvima.Rows.Add(sveKategorijeRow);

            foreach (DataRow row in DataSetManager.DS1.Kategorija.Rows)
            {
                kategorijeSaSvima.ImportRow(row);
            }
            return kategorijeSaSvima;
        }

    }
}
