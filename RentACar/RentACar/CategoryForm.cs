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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RentACar
{
    public partial class CategoryForm : Form
    {
        StartForm startForm;

        public CategoryForm(StartForm form)
        {
            InitializeComponent();
            startForm = form;
            txtNazivKategorija.Text = "";
            txtOpisKategorija.Text = "";
        }
        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            if (InputValidation.TextBoxesNotEmpty(this))
            {
                string naziv = txtNazivKategorija.Text;
                string opis = txtOpisKategorija.Text;

                if (DatabaseInsert.InsertCategory(naziv, opis))
                {
                    MessageBox.Show("Uspešno dodavanje kategorije", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataSetRefresh.RefreshCategoryTable();
                }
            }
        }
        private void goBackButtonSimulator_Click(object sender, EventArgs e)
        {
            this.Close();
            startForm.Show();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadTablesIntoGridView.LoadCategoryTable(dataGridViewKategorija);
        }
        private void CategoryForm_TextChanged(object sender, EventArgs e)
        {
            if (sender == txtNazivKategorija)
                InputValidation.ValidateString(lblErrorNazivKategorija, txtNazivKategorija);
            if (sender == txtOpisKategorija)
                InputValidation.ValidateString(lblErrorOpisKategorija, txtOpisKategorija);
        }
    }
}
