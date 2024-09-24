namespace RentACar
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.goBackButtonSimulator = new System.Windows.Forms.Panel();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtImeKorisnik = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezimeKorisnik = new System.Windows.Forms.TextBox();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.lblErrorImeKorisnik = new System.Windows.Forms.Label();
            this.lblErrorPrezimeKorisnik = new System.Windows.Forms.Label();
            this.dataGridViewKorisnik = new System.Windows.Forms.DataGridView();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.lblErrorAdresaKorisnik = new System.Windows.Forms.Label();
            this.txtAdresaKorisnik = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblErrorTelefonKorisnik = new System.Windows.Forms.Label();
            this.txtTelefonKorisnik = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblErrorDozvolaKorisnik = new System.Windows.Forms.Label();
            this.lblVozackaDozvola = new System.Windows.Forms.Label();
            this.klijentTableAdapter = new RentACar.RentACarDataSetTableAdapters.KlijentTableAdapter();
            this.cmbVozackaDozvola = new System.Windows.Forms.ComboBox();
            this.idklijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozackakategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goBackButtonSimulator
            // 
            this.goBackButtonSimulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goBackButtonSimulator.BackgroundImage")));
            this.goBackButtonSimulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goBackButtonSimulator.Location = new System.Drawing.Point(12, 414);
            this.goBackButtonSimulator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goBackButtonSimulator.Name = "goBackButtonSimulator";
            this.goBackButtonSimulator.Size = new System.Drawing.Size(72, 68);
            this.goBackButtonSimulator.TabIndex = 40;
            this.goBackButtonSimulator.Click += new System.EventHandler(this.goBackButtonSimulator_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIme.Location = new System.Drawing.Point(158, 31);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(41, 20);
            this.lblIme.TabIndex = 41;
            this.lblIme.Text = "Ime:";
            // 
            // txtImeKorisnik
            // 
            this.txtImeKorisnik.Location = new System.Drawing.Point(214, 25);
            this.txtImeKorisnik.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtImeKorisnik.Name = "txtImeKorisnik";
            this.txtImeKorisnik.Size = new System.Drawing.Size(170, 26);
            this.txtImeKorisnik.TabIndex = 42;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrezime.Location = new System.Drawing.Point(134, 100);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(69, 20);
            this.lblPrezime.TabIndex = 43;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtPrezimeKorisnik
            // 
            this.txtPrezimeKorisnik.Location = new System.Drawing.Point(214, 100);
            this.txtPrezimeKorisnik.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPrezimeKorisnik.Name = "txtPrezimeKorisnik";
            this.txtPrezimeKorisnik.Size = new System.Drawing.Size(170, 26);
            this.txtPrezimeKorisnik.TabIndex = 44;
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.BackColor = System.Drawing.Color.White;
            this.btnDodajKorisnika.ForeColor = System.Drawing.Color.Green;
            this.btnDodajKorisnika.Location = new System.Drawing.Point(162, 414);
            this.btnDodajKorisnika.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(162, 46);
            this.btnDodajKorisnika.TabIndex = 45;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // lblErrorImeKorisnik
            // 
            this.lblErrorImeKorisnik.AutoSize = true;
            this.lblErrorImeKorisnik.ForeColor = System.Drawing.Color.Red;
            this.lblErrorImeKorisnik.Location = new System.Drawing.Point(210, 56);
            this.lblErrorImeKorisnik.Name = "lblErrorImeKorisnik";
            this.lblErrorImeKorisnik.Size = new System.Drawing.Size(74, 20);
            this.lblErrorImeKorisnik.TabIndex = 46;
            this.lblErrorImeKorisnik.Text = "error ime";
            this.lblErrorImeKorisnik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorImeKorisnik.Visible = false;
            // 
            // lblErrorPrezimeKorisnik
            // 
            this.lblErrorPrezimeKorisnik.AutoSize = true;
            this.lblErrorPrezimeKorisnik.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrezimeKorisnik.Location = new System.Drawing.Point(212, 131);
            this.lblErrorPrezimeKorisnik.Name = "lblErrorPrezimeKorisnik";
            this.lblErrorPrezimeKorisnik.Size = new System.Drawing.Size(105, 20);
            this.lblErrorPrezimeKorisnik.TabIndex = 47;
            this.lblErrorPrezimeKorisnik.Text = "error prezime";
            this.lblErrorPrezimeKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorPrezimeKorisnik.Visible = false;
            // 
            // dataGridViewKorisnik
            // 
            this.dataGridViewKorisnik.AllowUserToAddRows = false;
            this.dataGridViewKorisnik.AllowUserToDeleteRows = false;
            this.dataGridViewKorisnik.AutoGenerateColumns = false;
            this.dataGridViewKorisnik.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklijentaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.vozackakategorijaDataGridViewTextBoxColumn});
            this.dataGridViewKorisnik.DataSource = this.klijentBindingSource;
            this.dataGridViewKorisnik.Location = new System.Drawing.Point(-6, 0);
            this.dataGridViewKorisnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewKorisnik.Name = "dataGridViewKorisnik";
            this.dataGridViewKorisnik.RowHeadersWidth = 51;
            this.dataGridViewKorisnik.RowTemplate.Height = 24;
            this.dataGridViewKorisnik.Size = new System.Drawing.Size(638, 382);
            this.dataGridViewKorisnik.TabIndex = 50;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.rentACarDataSet;
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblErrorAdresaKorisnik
            // 
            this.lblErrorAdresaKorisnik.AutoSize = true;
            this.lblErrorAdresaKorisnik.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAdresaKorisnik.Location = new System.Drawing.Point(212, 205);
            this.lblErrorAdresaKorisnik.Name = "lblErrorAdresaKorisnik";
            this.lblErrorAdresaKorisnik.Size = new System.Drawing.Size(99, 20);
            this.lblErrorAdresaKorisnik.TabIndex = 53;
            this.lblErrorAdresaKorisnik.Text = "error adresa";
            this.lblErrorAdresaKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorAdresaKorisnik.Visible = false;
            // 
            // txtAdresaKorisnik
            // 
            this.txtAdresaKorisnik.Location = new System.Drawing.Point(214, 174);
            this.txtAdresaKorisnik.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAdresaKorisnik.Name = "txtAdresaKorisnik";
            this.txtAdresaKorisnik.Size = new System.Drawing.Size(170, 26);
            this.txtAdresaKorisnik.TabIndex = 52;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdresa.Location = new System.Drawing.Point(21, 177);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(182, 20);
            this.lblAdresa.TabIndex = 51;
            this.lblAdresa.Text = "Adresa (Ulica 10, Grad):";
            // 
            // lblErrorTelefonKorisnik
            // 
            this.lblErrorTelefonKorisnik.AutoSize = true;
            this.lblErrorTelefonKorisnik.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTelefonKorisnik.Location = new System.Drawing.Point(211, 277);
            this.lblErrorTelefonKorisnik.Name = "lblErrorTelefonKorisnik";
            this.lblErrorTelefonKorisnik.Size = new System.Drawing.Size(100, 20);
            this.lblErrorTelefonKorisnik.TabIndex = 56;
            this.lblErrorTelefonKorisnik.Text = "error telefon";
            this.lblErrorTelefonKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorTelefonKorisnik.Visible = false;
            // 
            // txtTelefonKorisnik
            // 
            this.txtTelefonKorisnik.Location = new System.Drawing.Point(216, 246);
            this.txtTelefonKorisnik.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTelefonKorisnik.Name = "txtTelefonKorisnik";
            this.txtTelefonKorisnik.Size = new System.Drawing.Size(170, 26);
            this.txtTelefonKorisnik.TabIndex = 55;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefon.Location = new System.Drawing.Point(11, 249);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(192, 20);
            this.lblTelefon.TabIndex = 54;
            this.lblTelefon.Text = "Telefon (+381 23 6231232):";
            // 
            // lblErrorDozvolaKorisnik
            // 
            this.lblErrorDozvolaKorisnik.AutoSize = true;
            this.lblErrorDozvolaKorisnik.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDozvolaKorisnik.Location = new System.Drawing.Point(211, 355);
            this.lblErrorDozvolaKorisnik.Name = "lblErrorDozvolaKorisnik";
            this.lblErrorDozvolaKorisnik.Size = new System.Drawing.Size(107, 20);
            this.lblErrorDozvolaKorisnik.TabIndex = 59;
            this.lblErrorDozvolaKorisnik.Text = "error dozvola";
            this.lblErrorDozvolaKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorDozvolaKorisnik.Visible = false;
            // 
            // lblVozackaDozvola
            // 
            this.lblVozackaDozvola.AutoSize = true;
            this.lblVozackaDozvola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVozackaDozvola.Location = new System.Drawing.Point(47, 327);
            this.lblVozackaDozvola.Name = "lblVozackaDozvola";
            this.lblVozackaDozvola.Size = new System.Drawing.Size(156, 20);
            this.lblVozackaDozvola.TabIndex = 57;
            this.lblVozackaDozvola.Text = "Vozačka kategorija:";
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // cmbVozackaDozvola
            // 
            this.cmbVozackaDozvola.FormattingEnabled = true;
            this.cmbVozackaDozvola.Items.AddRange(new object[] {
            "B",
            "BE",
            "B1"});
            this.cmbVozackaDozvola.Location = new System.Drawing.Point(214, 324);
            this.cmbVozackaDozvola.Name = "cmbVozackaDozvola";
            this.cmbVozackaDozvola.Size = new System.Drawing.Size(170, 28);
            this.cmbVozackaDozvola.TabIndex = 60;
            // 
            // idklijentaDataGridViewTextBoxColumn
            // 
            this.idklijentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idklijentaDataGridViewTextBoxColumn.DataPropertyName = "id_klijenta";
            this.idklijentaDataGridViewTextBoxColumn.HeaderText = "Id klijenta";
            this.idklijentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklijentaDataGridViewTextBoxColumn.Name = "idklijentaDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // vozackakategorijaDataGridViewTextBoxColumn
            // 
            this.vozackakategorijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vozackakategorijaDataGridViewTextBoxColumn.DataPropertyName = "vozacka_kategorija";
            this.vozackakategorijaDataGridViewTextBoxColumn.HeaderText = "Vozačka kategorija";
            this.vozackakategorijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vozackakategorijaDataGridViewTextBoxColumn.Name = "vozackakategorijaDataGridViewTextBoxColumn";
            this.vozackakategorijaDataGridViewTextBoxColumn.Width = 165;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.cmbVozackaDozvola);
            this.panel1.Controls.Add(this.lblIme);
            this.panel1.Controls.Add(this.lblErrorDozvolaKorisnik);
            this.panel1.Controls.Add(this.txtImeKorisnik);
            this.panel1.Controls.Add(this.lblVozackaDozvola);
            this.panel1.Controls.Add(this.lblPrezime);
            this.panel1.Controls.Add(this.lblErrorTelefonKorisnik);
            this.panel1.Controls.Add(this.txtPrezimeKorisnik);
            this.panel1.Controls.Add(this.txtTelefonKorisnik);
            this.panel1.Controls.Add(this.btnDodajKorisnika);
            this.panel1.Controls.Add(this.lblTelefon);
            this.panel1.Controls.Add(this.lblErrorImeKorisnik);
            this.panel1.Controls.Add(this.lblErrorAdresaKorisnik);
            this.panel1.Controls.Add(this.lblErrorPrezimeKorisnik);
            this.panel1.Controls.Add(this.txtAdresaKorisnik);
            this.panel1.Controls.Add(this.lblAdresa);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(627, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 525);
            this.panel1.TabIndex = 61;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1082, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewKorisnik);
            this.Controls.Add(this.goBackButtonSimulator);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.TextChanged += new System.EventHandler(this.UserForm_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel goBackButtonSimulator;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtImeKorisnik;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezimeKorisnik;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Label lblErrorImeKorisnik;
        private System.Windows.Forms.Label lblErrorPrezimeKorisnik;
        private System.Windows.Forms.DataGridView dataGridViewKorisnik;
        private System.Windows.Forms.Label lblErrorAdresaKorisnik;
        private System.Windows.Forms.TextBox txtAdresaKorisnik;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblErrorTelefonKorisnik;
        private System.Windows.Forms.TextBox txtTelefonKorisnik;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblErrorDozvolaKorisnik;
        private System.Windows.Forms.Label lblVozackaDozvola;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private RentACarDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.ComboBox cmbVozackaDozvola;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozackakategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}