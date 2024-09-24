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
    public partial class VehicleForm : Form
    {
        StartForm startForm;
        public VehicleForm(StartForm form)
        {
            InitializeComponent();
            startForm = form;
            dtpDatumKraj.ValueChanged += dtpDatumPocetak_ValueChanged;
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            LoadTablesIntoGridView.LoadVehicleTable(dataGridViewVozilo);
            LoadDataIntoComboBox.LoadCategoriesIntoComboBoxWithALlOption(cmbKategorija);
            TrackBarManager.LoadMaxPriceIntoTrackBar(tbCena);
            LabelManager.UpdatePriceLabel(lblMaxCena);

        }
        private void AddNewVehicleForm_addedNewVehicle(object sender)
        {
            ComboBox cmb = sender as ComboBox;
            cmbKategorija.SelectedValue = (int)cmb.SelectedValue;
        }
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            AddNewVehicleForm novoVoziloForma = new AddNewVehicleForm(this);
            novoVoziloForma.addedNewVehicle += AddNewVehicleForm_addedNewVehicle;
            this.Hide();
            novoVoziloForma.ShowDialog();

            this.Show();
        }

        private void nazadDugmeSimulator_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }

        private void cmbKategorija_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbKategorija.SelectedValue != null)
            {
                int idKategorija = (int)cmbKategorija.SelectedValue;

                DataTable trenutnaTabela = dataGridViewVozilo.DataSource as DataTable;
                DataTable filtriranaTabela = GetFilteredTable.FilteredVehiclesTableByCategory(trenutnaTabela, idKategorija);

                dataGridViewVozilo.DataSource = filtriranaTabela;
            }
        }

        private void tbCena_Scroll(object sender, EventArgs e)
        {
            DataTable trenutnaTabela = dataGridViewVozilo.DataSource as DataTable;
            //nazad u double (prilikom postavljanja maks cena * 100)
            int trenutnaCena = tbCena.Value / 100;
            lblMaxCena.Text = trenutnaCena.ToString();

            DataTable novaTabela = GetFilteredTable.FilteredTableByPrice(trenutnaCena);
            dataGridViewVozilo.DataSource = novaTabela;
        }

        private void dtpDatumPocetak_ValueChanged(object sender, EventArgs e)
        {
            if (InputValidation.ValidDateRange(dtpDatumPocetak, dtpDatumKraj))
            {
                DataTable trenutnaTabela = dataGridViewVozilo.DataSource as DataTable;
                DateTime pocetak = dtpDatumPocetak.Value;
                DateTime kraj = dtpDatumKraj.Value;
                DataTable filtriranaTabela = GetFilteredTable.FilteredTableByAvailableVehicles(pocetak, kraj);

                dataGridViewVozilo.DataSource = filtriranaTabela;
            }
        }
    }
}
