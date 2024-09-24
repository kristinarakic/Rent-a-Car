using ProjekatTVP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class ReservationForm : Form
    {
        StartForm startForm;
        public ReservationForm(StartForm form)
        {
            InitializeComponent();
            startForm = form;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            LoadTablesIntoGridView.LoadReservationTable(dataGridViewRezervacija);
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            AlterResrevationForm alterResrevationForm = new AlterResrevationForm(this);
            this.Hide();
            alterResrevationForm.ShowDialog();
            this.Show();
        }
        private void goBackButtonSimulator_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }
        private void dtpPocetakPrikaz_ValueChanged(object sender, EventArgs e)
        {
            DateTime pocetak = dtpPocetakPrikaz.Value;
            DateTime kraj = dtpKrajPrikaz.Value;

            dataGridViewRezervacija.DataSource = GetReservationData.GetReservationsInPeriod(pocetak, kraj);
        }
        private void dtpKrajPrikaz_ValueChanged(object sender, EventArgs e)
        {
            if (InputValidation.ValidDateRange(dtpPocetakPrikaz, dtpKrajPrikaz))
            {
                DateTime pocetak = dtpPocetakPrikaz.Value;
                DateTime kraj = dtpKrajPrikaz.Value;

                dataGridViewRezervacija.DataSource = GetReservationData.GetReservationsInPeriod(pocetak, kraj);
            }
        }
    }
}
