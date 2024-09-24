namespace RentACar
{
    partial class AlterResrevationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterResrevationForm));
            this.goBackButtonSimulator = new System.Windows.Forms.Panel();
            this.cmbVoziloRezervacija = new System.Windows.Forms.ComboBox();
            this.cmbKorisnikRezervacija = new System.Windows.Forms.ComboBox();
            this.dtpPocetakRezervacije = new System.Windows.Forms.DateTimePicker();
            this.nupBrojDana = new System.Windows.Forms.NumericUpDown();
            this.nupBrojSati = new System.Windows.Forms.NumericUpDown();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.lblPocetakRezervacije = new System.Windows.Forms.Label();
            this.lblBrojDana = new System.Windows.Forms.Label();
            this.lblBrojSati = new System.Windows.Forms.Label();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.dataGridViewRezervacijaIzmena = new System.Windows.Forms.DataGridView();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.btnIzmeniRezervaciju = new System.Windows.Forms.Button();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblCenaRezervacija = new System.Windows.Forms.Label();
            this.rezervacijaTableAdapter = new RentACar.RentACarDataSetTableAdapters.RezervacijaTableAdapter();
            this.lblNaslovTabeleReervacija = new System.Windows.Forms.Label();
            this.id_rezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_klijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVreme_pocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVreme_kraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nupBrojDana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBrojSati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacijaIzmena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // goBackButtonSimulator
            // 
            this.goBackButtonSimulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goBackButtonSimulator.BackgroundImage")));
            this.goBackButtonSimulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goBackButtonSimulator.Location = new System.Drawing.Point(14, 329);
            this.goBackButtonSimulator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goBackButtonSimulator.Name = "goBackButtonSimulator";
            this.goBackButtonSimulator.Size = new System.Drawing.Size(64, 63);
            this.goBackButtonSimulator.TabIndex = 41;
            this.goBackButtonSimulator.Click += new System.EventHandler(this.goBackButtonSimulator_Click);
            // 
            // cmbVoziloRezervacija
            // 
            this.cmbVoziloRezervacija.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbVoziloRezervacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoziloRezervacija.FormattingEnabled = true;
            this.cmbVoziloRezervacija.Location = new System.Drawing.Point(135, 34);
            this.cmbVoziloRezervacija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVoziloRezervacija.Name = "cmbVoziloRezervacija";
            this.cmbVoziloRezervacija.Size = new System.Drawing.Size(154, 28);
            this.cmbVoziloRezervacija.TabIndex = 42;
            // 
            // cmbKorisnikRezervacija
            // 
            this.cmbKorisnikRezervacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKorisnikRezervacija.FormattingEnabled = true;
            this.cmbKorisnikRezervacija.Location = new System.Drawing.Point(135, 93);
            this.cmbKorisnikRezervacija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKorisnikRezervacija.Name = "cmbKorisnikRezervacija";
            this.cmbKorisnikRezervacija.Size = new System.Drawing.Size(154, 28);
            this.cmbKorisnikRezervacija.TabIndex = 43;
            // 
            // dtpPocetakRezervacije
            // 
            this.dtpPocetakRezervacije.CausesValidation = false;
            this.dtpPocetakRezervacije.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpPocetakRezervacije.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetakRezervacije.Location = new System.Drawing.Point(135, 154);
            this.dtpPocetakRezervacije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPocetakRezervacije.MinDate = new System.DateTime(2024, 9, 16, 0, 0, 0, 0);
            this.dtpPocetakRezervacije.Name = "dtpPocetakRezervacije";
            this.dtpPocetakRezervacije.Size = new System.Drawing.Size(224, 26);
            this.dtpPocetakRezervacije.TabIndex = 44;
            // 
            // nupBrojDana
            // 
            this.nupBrojDana.Location = new System.Drawing.Point(135, 212);
            this.nupBrojDana.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupBrojDana.Name = "nupBrojDana";
            this.nupBrojDana.Size = new System.Drawing.Size(158, 26);
            this.nupBrojDana.TabIndex = 46;
            this.nupBrojDana.ValueChanged += new System.EventHandler(this.nupBrojDana_ValueChanged);
            // 
            // nupBrojSati
            // 
            this.nupBrojSati.Location = new System.Drawing.Point(135, 275);
            this.nupBrojSati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupBrojSati.Name = "nupBrojSati";
            this.nupBrojSati.Size = new System.Drawing.Size(158, 26);
            this.nupBrojSati.TabIndex = 47;
            this.nupBrojSati.ValueChanged += new System.EventHandler(this.nupBrojDana_ValueChanged);
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(59, 37);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(56, 20);
            this.lblVozilo.TabIndex = 48;
            this.lblVozilo.Text = "Vozilo:";
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Location = new System.Drawing.Point(64, 96);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(55, 20);
            this.lblKlijent.TabIndex = 49;
            this.lblKlijent.Text = "Klijent:";
            this.lblKlijent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPocetakRezervacije
            // 
            this.lblPocetakRezervacije.AutoSize = true;
            this.lblPocetakRezervacije.Location = new System.Drawing.Point(40, 160);
            this.lblPocetakRezervacije.Name = "lblPocetakRezervacije";
            this.lblPocetakRezervacije.Size = new System.Drawing.Size(75, 20);
            this.lblPocetakRezervacije.TabIndex = 50;
            this.lblPocetakRezervacije.Text = "Početak:";
            // 
            // lblBrojDana
            // 
            this.lblBrojDana.AutoSize = true;
            this.lblBrojDana.Location = new System.Drawing.Point(32, 214);
            this.lblBrojDana.Name = "lblBrojDana";
            this.lblBrojDana.Size = new System.Drawing.Size(83, 20);
            this.lblBrojDana.TabIndex = 51;
            this.lblBrojDana.Text = "Broj dana:";
            // 
            // lblBrojSati
            // 
            this.lblBrojSati.AutoSize = true;
            this.lblBrojSati.Location = new System.Drawing.Point(47, 275);
            this.lblBrojSati.Name = "lblBrojSati";
            this.lblBrojSati.Size = new System.Drawing.Size(68, 20);
            this.lblBrojSati.TabIndex = 52;
            this.lblBrojSati.Text = "Broj sati:";
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.White;
            this.btnDodajRezervaciju.ForeColor = System.Drawing.Color.Green;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(11, 52);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(136, 41);
            this.btnDodajRezervaciju.TabIndex = 53;
            this.btnDodajRezervaciju.Text = "Dodaj";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // dataGridViewRezervacijaIzmena
            // 
            this.dataGridViewRezervacijaIzmena.AllowUserToAddRows = false;
            this.dataGridViewRezervacijaIzmena.AllowUserToDeleteRows = false;
            this.dataGridViewRezervacijaIzmena.AllowUserToOrderColumns = true;
            this.dataGridViewRezervacijaIzmena.AutoGenerateColumns = false;
            this.dataGridViewRezervacijaIzmena.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRezervacijaIzmena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacijaIzmena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rezervacija,
            this.id_vozila,
            this.id_klijenta,
            this.datumVreme_pocetka,
            this.datumVreme_kraja,
            this.cena});
            this.dataGridViewRezervacijaIzmena.DataSource = this.rezervacijaBindingSource;
            this.dataGridViewRezervacijaIzmena.Location = new System.Drawing.Point(151, 47);
            this.dataGridViewRezervacijaIzmena.MultiSelect = false;
            this.dataGridViewRezervacijaIzmena.Name = "dataGridViewRezervacijaIzmena";
            this.dataGridViewRezervacijaIzmena.ReadOnly = true;
            this.dataGridViewRezervacijaIzmena.RowHeadersWidth = 51;
            this.dataGridViewRezervacijaIzmena.RowTemplate.Height = 24;
            this.dataGridViewRezervacijaIzmena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRezervacijaIzmena.Size = new System.Drawing.Size(699, 345);
            this.dataGridViewRezervacijaIzmena.TabIndex = 54;
            this.dataGridViewRezervacijaIzmena.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRezervacijaIzmena_CellClick);
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "Rezervacija";
            this.rezervacijaBindingSource.DataSource = this.rentACarDataSet;
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIzmeniRezervaciju
            // 
            this.btnIzmeniRezervaciju.BackColor = System.Drawing.Color.White;
            this.btnIzmeniRezervaciju.ForeColor = System.Drawing.Color.Green;
            this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(11, 132);
            this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
            this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(136, 41);
            this.btnIzmeniRezervaciju.TabIndex = 55;
            this.btnIzmeniRezervaciju.Text = "Izmeni";
            this.btnIzmeniRezervaciju.UseVisualStyleBackColor = false;
            this.btnIzmeniRezervaciju.Click += new System.EventHandler(this.btnIzmeniRezervaciju_Click);
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.BackColor = System.Drawing.Color.White;
            this.btnObrisiRezervaciju.ForeColor = System.Drawing.Color.Green;
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(11, 212);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(136, 41);
            this.btnObrisiRezervaciju.TabIndex = 56;
            this.btnObrisiRezervaciju.Text = "Obriši";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = false;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(135, 337);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(158, 26);
            this.txtCena.TabIndex = 57;
            // 
            // lblCenaRezervacija
            // 
            this.lblCenaRezervacija.AutoSize = true;
            this.lblCenaRezervacija.Location = new System.Drawing.Point(39, 337);
            this.lblCenaRezervacija.Name = "lblCenaRezervacija";
            this.lblCenaRezervacija.Size = new System.Drawing.Size(80, 20);
            this.lblCenaRezervacija.TabIndex = 58;
            this.lblCenaRezervacija.Text = "Cena (€): ";
            // 
            // rezervacijaTableAdapter
            // 
            this.rezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // lblNaslovTabeleReervacija
            // 
            this.lblNaslovTabeleReervacija.AutoSize = true;
            this.lblNaslovTabeleReervacija.Location = new System.Drawing.Point(157, 24);
            this.lblNaslovTabeleReervacija.Name = "lblNaslovTabeleReervacija";
            this.lblNaslovTabeleReervacija.Size = new System.Drawing.Size(342, 20);
            this.lblNaslovTabeleReervacija.TabIndex = 59;
            this.lblNaslovTabeleReervacija.Text = "Za izmenu / brisanje izaberite rezervaciju (klik):";
            // 
            // id_rezervacija
            // 
            this.id_rezervacija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_rezervacija.DataPropertyName = "id_rezervacija";
            this.id_rezervacija.HeaderText = "Id rezervacije";
            this.id_rezervacija.MinimumWidth = 6;
            this.id_rezervacija.Name = "id_rezervacija";
            this.id_rezervacija.ReadOnly = true;
            // 
            // id_vozila
            // 
            this.id_vozila.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_vozila.DataPropertyName = "id_vozila";
            this.id_vozila.HeaderText = "Id vozila";
            this.id_vozila.MinimumWidth = 6;
            this.id_vozila.Name = "id_vozila";
            this.id_vozila.ReadOnly = true;
            // 
            // id_klijenta
            // 
            this.id_klijenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_klijenta.DataPropertyName = "id_klijenta";
            this.id_klijenta.HeaderText = "Id klijenta";
            this.id_klijenta.MinimumWidth = 6;
            this.id_klijenta.Name = "id_klijenta";
            this.id_klijenta.ReadOnly = true;
            // 
            // datumVreme_pocetka
            // 
            this.datumVreme_pocetka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumVreme_pocetka.DataPropertyName = "datumVreme_pocetka";
            this.datumVreme_pocetka.HeaderText = "Početak rezervacije";
            this.datumVreme_pocetka.MinimumWidth = 6;
            this.datumVreme_pocetka.Name = "datumVreme_pocetka";
            this.datumVreme_pocetka.ReadOnly = true;
            // 
            // datumVreme_kraja
            // 
            this.datumVreme_kraja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumVreme_kraja.DataPropertyName = "datumVreme_kraja";
            this.datumVreme_kraja.HeaderText = "Kraj rezervacije";
            this.datumVreme_kraja.MinimumWidth = 6;
            this.datumVreme_kraja.Name = "datumVreme_kraja";
            this.datumVreme_kraja.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cena.DataPropertyName = "cena";
            this.cena.HeaderText = "Cena";
            this.cena.MinimumWidth = 6;
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.nupBrojDana);
            this.panel1.Controls.Add(this.cmbVoziloRezervacija);
            this.panel1.Controls.Add(this.lblCenaRezervacija);
            this.panel1.Controls.Add(this.cmbKorisnikRezervacija);
            this.panel1.Controls.Add(this.txtCena);
            this.panel1.Controls.Add(this.dtpPocetakRezervacije);
            this.panel1.Controls.Add(this.nupBrojSati);
            this.panel1.Controls.Add(this.lblVozilo);
            this.panel1.Controls.Add(this.lblKlijent);
            this.panel1.Controls.Add(this.lblPocetakRezervacije);
            this.panel1.Controls.Add(this.lblBrojSati);
            this.panel1.Controls.Add(this.lblBrojDana);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(848, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 392);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnObrisiRezervaciju);
            this.panel2.Controls.Add(this.goBackButtonSimulator);
            this.panel2.Controls.Add(this.btnDodajRezervaciju);
            this.panel2.Controls.Add(this.btnIzmeniRezervaciju);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 392);
            this.panel2.TabIndex = 61;
            // 
            // AlterResrevationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1222, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNaslovTabeleReervacija);
            this.Controls.Add(this.dataGridViewRezervacijaIzmena);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AlterResrevationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterResrevationForm";
            this.Load += new System.EventHandler(this.AlterResrevationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBrojDana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBrojSati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacijaIzmena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel goBackButtonSimulator;
        private System.Windows.Forms.ComboBox cmbVoziloRezervacija;
        private System.Windows.Forms.ComboBox cmbKorisnikRezervacija;
        private System.Windows.Forms.DateTimePicker dtpPocetakRezervacije;
        private System.Windows.Forms.NumericUpDown nupBrojDana;
        private System.Windows.Forms.NumericUpDown nupBrojSati;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.Label lblPocetakRezervacije;
        private System.Windows.Forms.Label lblBrojDana;
        private System.Windows.Forms.Label lblBrojSati;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.DataGridView dataGridViewRezervacijaIzmena;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private RentACarDataSetTableAdapters.RezervacijaTableAdapter rezervacijaTableAdapter;
        private System.Windows.Forms.Button btnIzmeniRezervaciju;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblCenaRezervacija;
        private System.Windows.Forms.Label lblNaslovTabeleReervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_klijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVreme_pocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVreme_kraja;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}