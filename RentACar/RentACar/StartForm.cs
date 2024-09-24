using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            lblNajpopularnijeVozilo.Text = GetVehicleData.MostPopularVehicleName();
            Task.Run(AnimateFromLeftToRight);
        }

        private void btnKategorije_Click(object sender, EventArgs e)
        {
            CategoryForm kategorijaForma = new CategoryForm(this);
            this.Hide();
            kategorijaForma.ShowDialog();
            this.Show();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            VehicleForm voziloForma = new VehicleForm(this);
            this.Hide();
            voziloForma.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm korisnikForma = new UserForm(this);
            this.Hide();
            korisnikForma.ShowDialog();
            this.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            ReservationForm rezervacijaForma = new ReservationForm(this);
            this.Hide();
            rezervacijaForma.ShowDialog();
            this.Show();
        }

        private async Task AnimateFromLeftToRight()
        {
            string imeVozila = lblNajpopularnijeVozilo.Text;
            int brojac = 0;

            while (brojac < imeVozila.Length)
            {
                this.Invoke((Action)(() =>
                {
                    lblNajpopularnijeVozilo.Text = imeVozila.Substring(0, brojac + 1);
                }));

                brojac++;
                await Task.Delay(200); 
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
