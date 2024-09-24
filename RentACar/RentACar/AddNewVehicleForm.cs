using ProjekatTVP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RentACar
{
    public partial class AddNewVehicleForm : Form
    {
        VehicleForm vehicleForm;
        public event Action<ComboBox> addedNewVehicle;
        
        public AddNewVehicleForm(VehicleForm form)
        {
            InitializeComponent();
            vehicleForm = form;
            AssignTextChangeEvent();
        }
        private void AddNewVehicleForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox.LoadCategoriesIntoComboBox(cmbKategorijaVozilo);
        }
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            if (InputValidation.TextBoxesNotEmpty(this))
            {
                 int idKategorija = (int)cmbKategorijaVozilo.SelectedValue;
                 string naziv = txtNaziv.Text;
                 string marka = txtMarkaVozilo.Text;
                 string model = txtModelVozilo.Text;
                 int godina = int.Parse(txtGodinaProizvodnje.Text);
                 double cena = int.Parse(txtCenaPoSatu.Text);

                 if (DatabaseInsert.InsertVehicle(idKategorija, naziv, marka, model, godina, cena))
                 {
                     MessageBox.Show("Uspešno dodavanje vozila", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     DataSetRefresh.RefreshVehicleTable();
                     addedNewVehicle?.Invoke(cmbKategorijaVozilo);
                     pnlNazadDugmeSimulator_Click(sender, e);
                 }
                 else
                 {
                     MessageBox.Show("Neuspešno dodavanje vozila", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
            }
        }
        private void AddNewVehicle_TextChanged(object sender, EventArgs e)
        {
            if (sender == txtNaziv)
                InputValidation.ValidateStringInteger(lblErrorNazivVozilo, txtNaziv);
            if (sender == txtModelVozilo)
                InputValidation.ValidateStringInteger(lblErrorModelVozilo, txtModelVozilo);
            if (sender == txtMarkaVozilo)
                InputValidation.ValidateString(lblErrorMarkaVozilo, txtMarkaVozilo);
            if (sender == txtGodinaProizvodnje)
                InputValidation.ValidateIntegerNumber(lblErrorGodinaVozilo, txtGodinaProizvodnje);
            if (sender == txtCenaPoSatu)
                InputValidation.ValidateDoubleNumber(lblErrorCenaVozilo, txtCenaPoSatu);
        }
        private void pnlNazadDugmeSimulator_Click(object sender, EventArgs e)
        {
            this.Close();
            vehicleForm.Show();
        }
        private void AssignTextChangeEvent() 
        {
            txtNaziv.TextChanged += AddNewVehicle_TextChanged;
            txtCenaPoSatu.TextChanged += AddNewVehicle_TextChanged;
            txtGodinaProizvodnje.TextChanged += AddNewVehicle_TextChanged;
            txtMarkaVozilo.TextChanged += AddNewVehicle_TextChanged;
            txtModelVozilo.TextChanged += AddNewVehicle_TextChanged;
            txtNaziv.TextChanged += AddNewVehicle_TextChanged;
        }
    }
}
