using RentACar.RentACarDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace RentACar
{
    internal class DataSetManager
    {

        private static string conString = ConfigurationManager.ConnectionStrings["RentACarDB"].ConnectionString;
        private static RentACarDataSet DS = new RentACarDataSet();

        public static RentACarDataSet DS1 { get => DS;}
        public static string ConString { get => conString; set => conString = value; }
    }
}
