using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class LabelManager
    {
        public static void UpdatePriceLabel(Label max)
        {
            double izabranaVrednost = Calculator.MaxPrice();
            max.Text = izabranaVrednost.ToString("F2");
        }
    }
}
