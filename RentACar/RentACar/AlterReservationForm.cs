using ProjekatTVP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class AlterResrevationForm : Form
    {
        ReservationForm reservationForm;
        DateTime trenutnoVreme;
        public AlterResrevationForm(ReservationForm form)
        {
            InitializeComponent();
            reservationForm = form;
            trenutnoVreme = new DateTime();
        }

        private void goBackButtonSimulator_Click(object sender, EventArgs e)
        {
            this.Close();
            reservationForm.Show();
        }
        private void AlterResrevationForm_Load(object sender, EventArgs e)
        {
            trenutnoVreme = dtpPocetakRezervacije.Value;
            LoadTablesIntoGridView.LoadReservationTable(dataGridViewRezervacijaIzmena);
            LoadDataIntoComboBox.LoadVehiclesIntoComboBoxBrandAndModel(cmbVoziloRezervacija);
            LoadDataIntoComboBox.LoadUsersIntoComboBox(cmbKorisnikRezervacija);
        }
        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            int idVozila = (int)cmbVoziloRezervacija.SelectedValue;
            int idKorisika =(int)cmbKorisnikRezervacija.SelectedValue;
            DateTime pocetakRezervacije = dtpPocetakRezervacije.Value;
            int brojDana = Convert.ToInt32(nupBrojDana.Value);
            int brojSati = Convert.ToInt32(nupBrojSati.Value);

            if (dtpPocetakRezervacije.Value == trenutnoVreme)
            {
                MessageBox.Show("Morate uneti datum i vreme početka rezervacije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (brojDana == 0 && brojSati == 0)
            {
                MessageBox.Show("Morate uneti bar jedno od polja 'Broj dana' i 'Broj sati'", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (DatabaseInsert.InsertReservation(idVozila, idKorisika, pocetakRezervacije, brojDana, brojSati))
            {
                MessageBox.Show("Uspešno dodavanje rezervacije", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSetRefresh.RefreshReservationTable();
            }
          
        }
        private void nupBrojDana_ValueChanged(object sender, EventArgs e)
        {
            int brojDana = int.Parse(nupBrojDana.Value.ToString());
            int brojSati = int.Parse(nupBrojSati.Value.ToString());
            int idVozila = int.Parse(cmbVoziloRezervacija.SelectedValue.ToString());
            txtCena.Text = Calculator.ReservationPrice(idVozila, brojDana, brojSati).ToString();
        }
        private void dataGridViewRezervacijaIzmena_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow izabraniRed = dataGridViewRezervacijaIzmena.Rows[e.RowIndex];

                int id = (int)izabraniRed.Cells["id_rezervacija"].Value;
                var idVozila = izabraniRed.Cells["id_vozila"].Value;
                var idKlijenta = izabraniRed.Cells["id_klijenta"].Value;
                DateTime datumVremePocetka = DateTime.Parse(izabraniRed.Cells["datumVreme_pocetka"].Value.ToString());
                DateTime datumVremeKraja = DateTime.Parse(izabraniRed.Cells["datumVreme_kraja"].Value.ToString());
                var cena = izabraniRed.Cells["cena"].Value;

                TimeSpan razlikaDatuma = datumVremeKraja - datumVremePocetka;

                cmbKorisnikRezervacija.SelectedValue = idKlijenta;
                cmbVoziloRezervacija.SelectedValue = idVozila;
                dtpPocetakRezervacije.Value = DateTime.Parse(datumVremePocetka.ToString());
                nupBrojDana.Value = razlikaDatuma.Days;
                nupBrojSati.Value = razlikaDatuma.Hours;
            
            }
        }
        private void btnIzmeniRezervaciju_Click(object sender, EventArgs e)
        {
            if (dataGridViewRezervacijaIzmena.SelectedRows.Count > 0)
            {
                DataGridViewRow izabraniRed = dataGridViewRezervacijaIzmena.SelectedRows[0];

                int id = (int)izabraniRed.Cells["id_rezervacija"].Value;
                int idVozila = (int)cmbVoziloRezervacija.SelectedValue;
                int idKlijenta = (int)cmbKorisnikRezervacija.SelectedValue;
                DateTime datumVremePocetka = dtpPocetakRezervacije.Value;
                int brojDana = (int)nupBrojDana.Value;
                int brojSati = (int)nupBrojSati.Value;

                if (dtpPocetakRezervacije.Value == trenutnoVreme)
                {
                    MessageBox.Show("Morate uneti datum i vreme početka rezervacije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (brojDana == 0 && brojSati == 0)
                {
                    MessageBox.Show("Morate uneti bar jedno od polja 'Broj dana' i 'Broj sati'", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (DatabaseUpdate.UpdateReservation(id, idVozila, idKlijenta, datumVremePocetka, brojDana, brojSati))
                {
                     MessageBox.Show("Uspešna izmena rezervacije.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     DataSetRefresh.RefreshReservationTable();
                }
               
            }
            else
            {
                MessageBox.Show("Morate izabrati rezervaciju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            if (dataGridViewRezervacijaIzmena.SelectedRows.Count > 0)
            {
                DataGridViewRow izabraniRed = dataGridViewRezervacijaIzmena.SelectedRows[0];

                int id = (int)izabraniRed.Cells["id_rezervacija"].Value;

                if (DatabaseDelete.DeleteReservation(id))
                {
                    MessageBox.Show("Uspešno brisanje rezervacije.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataSetRefresh.RefreshReservationTable();
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati rezervaciju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
