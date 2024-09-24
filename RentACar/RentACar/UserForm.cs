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
    public partial class UserForm : Form
    {
        StartForm startForm;
        public UserForm(StartForm form)
        {
            InitializeComponent();
            startForm = form;
        }

        private void goBackButtonSimulator_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadTablesIntoGridView.LoadUserTable(dataGridViewKorisnik);
        }
        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            if (InputValidation.TextBoxesNotEmpty(this))
            {
                string ime = txtImeKorisnik.Text;
                string prezime = txtPrezimeKorisnik.Text;
                string adresa = txtAdresaKorisnik.Text;
                string telefon = txtTelefonKorisnik.Text;
                string vozacka = cmbVozackaDozvola.Text;

                if (DatabaseInsert.InsertUser(ime, prezime, adresa, telefon, vozacka))
                {
                    MessageBox.Show("Uspešno dodavanje korisnika", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataSetRefresh.RefreshUserTable();
                }
                else
                {
                    MessageBox.Show("Neuspešno dodavanje korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void UserForm_TextChanged(object sender, EventArgs e)
        {
            if (sender == txtImeKorisnik)
                InputValidation.ValidateString(lblErrorImeKorisnik, txtImeKorisnik);
            if (sender == txtPrezimeKorisnik)
                InputValidation.ValidateString(lblErrorPrezimeKorisnik, txtPrezimeKorisnik);
            if (sender == txtAdresaKorisnik)
                InputValidation.ValidateAddress(lblErrorAdresaKorisnik, txtAdresaKorisnik);
            if (sender == txtTelefonKorisnik)
                InputValidation.ValidatePhoneNumber(lblErrorTelefonKorisnik, txtTelefonKorisnik);
        }
    }
}
