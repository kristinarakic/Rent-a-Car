using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class GetReservationData
    {
        public static bool ConditionForReservationOverlap(DateTime pocetak, DateTime kraj, DateTime unetPocetak, DateTime unetKraj)
        {
            return (unetPocetak <= pocetak && unetKraj >= kraj) ||  // nova rezervacija obuhvata postojeci interval
          (unetPocetak >= pocetak && unetPocetak < kraj) ||  // pocetak je izmedju
          (unetKraj > pocetak && unetKraj <= kraj) ||       // kraj je izmedju
          (unetPocetak > pocetak && unetKraj < kraj); // nova rezervacija u postojecem intervalu
        }
        public static DateTime EndOfReservationDate(DateTime datumPocetka, int brojDana, int brojSati)
        {
            return datumPocetka.AddDays(brojDana).AddHours(brojSati);
        }
        public static DataTable GetReservationsInPeriod(DateTime pocetak, DateTime kraj)
        {
            DataTable reservations = new DataTable();

            using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
            {
                string upit = "SELECT * FROM Rezervacija WHERE datumVreme_pocetka >= ? AND datumVreme_kraja <= ?";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(upit, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@pocetak", pocetak);
                    adapter.SelectCommand.Parameters.AddWithValue("@kraj", kraj);

                    con.Open();
                    adapter.Fill(reservations);
                }
            }
            return reservations;
        }

    }
}
