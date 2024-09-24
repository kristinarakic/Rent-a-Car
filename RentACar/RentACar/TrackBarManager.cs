using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class TrackBarManager
    {
        public static void LoadMaxPriceIntoTrackBar(TrackBar tb)
        {
            double maxPrice = Calculator.MaxPrice();

            tb.Maximum = (int)Math.Min(maxPrice * 100, 65535);
            tb.Minimum = 0; 
            tb.TickFrequency = (int)((tb.Maximum - tb.Minimum) / 10); 
        }
       
    }
}
