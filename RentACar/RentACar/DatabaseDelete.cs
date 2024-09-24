using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    internal class DatabaseDelete
    {
        public static bool DeleteReservation(int idRezervacije)
        {
            double preostaliBrojSati = Calculator.RemainingTimeUntilReservationStart(idRezervacije);
            if (preostaliBrojSati < 2)
            {
                MessageBox.Show("Brisanje dozvoljeno najkasnije 2 h pre početka rezervacije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                using (OleDbConnection con = new OleDbConnection(DataSetManager.ConString))
                {
                    string upit = "DELETE FROM Rezervacija WHERE id_rezervacija = @id_rezervacija";

                    using (OleDbCommand cmd = new OleDbCommand(upit, con))
                    {
                        cmd.Parameters.AddWithValue("@id_rezervacije", idRezervacije);

                        con.Open();
                        int izbrisaniRedovi = cmd.ExecuteNonQuery();
                        return izbrisaniRedovi > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DeleteException {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
