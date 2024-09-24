namespace RentACar
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewRezervacija = new System.Windows.Forms.DataGridView();
            this.rezervacijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpPocetakPrikaz = new System.Windows.Forms.DateTimePicker();
            this.dtpKrajPrikaz = new System.Windows.Forms.DateTimePicker();
            this.lblIzvestaj = new System.Windows.Forms.Label();
            this.lblOdDo = new System.Windows.Forms.Label();
            this.rezervacijaTableAdapter = new RentACar.RentACarDataSetTableAdapters.RezervacijaTableAdapter();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.goBackButtonSimulator = new System.Windows.Forms.Panel();
            this.idrezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVremepocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVremekrajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(9, 10);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewRezervacija
            // 
            this.dataGridViewRezervacija.AllowUserToAddRows = false;
            this.dataGridViewRezervacija.AllowUserToDeleteRows = false;
            this.dataGridViewRezervacija.AutoGenerateColumns = false;
            this.dataGridViewRezervacija.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrezervacijaDataGridViewTextBoxColumn,
            this.idvozilaDataGridViewTextBoxColumn,
            this.idklijentaDataGridViewTextBoxColumn,
            this.datumVremepocetkaDataGridViewTextBoxColumn,
            this.datumVremekrajaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridViewRezervacija.DataSource = this.rezervacijaBindingSource1;
            this.dataGridViewRezervacija.Location = new System.Drawing.Point(-7, 110);
            this.dataGridViewRezervacija.Name = "dataGridViewRezervacija";
            this.dataGridViewRezervacija.ReadOnly = true;
            this.dataGridViewRezervacija.RowHeadersWidth = 51;
            this.dataGridViewRezervacija.RowTemplate.Height = 24;
            this.dataGridViewRezervacija.Size = new System.Drawing.Size(769, 347);
            this.dataGridViewRezervacija.TabIndex = 1;
            // 
            // rezervacijaBindingSource1
            // 
            this.rezervacijaBindingSource1.DataMember = "Rezervacija";
            this.rezervacijaBindingSource1.DataSource = this.rentACarDataSet;
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "Rezervacija";
            this.rezervacijaBindingSource.DataSource = this.rentACarDataSet;
            // 
            // dtpPocetakPrikaz
            // 
            this.dtpPocetakPrikaz.Location = new System.Drawing.Point(103, 69);
            this.dtpPocetakPrikaz.Name = "dtpPocetakPrikaz";
            this.dtpPocetakPrikaz.Size = new System.Drawing.Size(255, 26);
            this.dtpPocetakPrikaz.TabIndex = 2;
            this.dtpPocetakPrikaz.ValueChanged += new System.EventHandler(this.dtpPocetakPrikaz_ValueChanged);
            // 
            // dtpKrajPrikaz
            // 
            this.dtpKrajPrikaz.Location = new System.Drawing.Point(441, 70);
            this.dtpKrajPrikaz.Name = "dtpKrajPrikaz";
            this.dtpKrajPrikaz.Size = new System.Drawing.Size(224, 26);
            this.dtpKrajPrikaz.TabIndex = 3;
            this.dtpKrajPrikaz.ValueChanged += new System.EventHandler(this.dtpKrajPrikaz_ValueChanged);
            // 
            // lblIzvestaj
            // 
            this.lblIzvestaj.AutoSize = true;
            this.lblIzvestaj.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzvestaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIzvestaj.Location = new System.Drawing.Point(275, 26);
            this.lblIzvestaj.Name = "lblIzvestaj";
            this.lblIzvestaj.Size = new System.Drawing.Size(243, 21);
            this.lblIzvestaj.TabIndex = 4;
            this.lblIzvestaj.Text = "Prikazi rezervacije u periodu:";
            // 
            // lblOdDo
            // 
            this.lblOdDo.AutoSize = true;
            this.lblOdDo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOdDo.Location = new System.Drawing.Point(394, 75);
            this.lblOdDo.Name = "lblOdDo";
            this.lblOdDo.Size = new System.Drawing.Size(14, 20);
            this.lblOdDo.TabIndex = 5;
            this.lblOdDo.Text = "-";
            // 
            // rezervacijaTableAdapter
            // 
            this.rezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.White;
            this.btnAzuriraj.ForeColor = System.Drawing.Color.Green;
            this.btnAzuriraj.Location = new System.Drawing.Point(311, 463);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(144, 49);
            this.btnAzuriraj.TabIndex = 6;
            this.btnAzuriraj.Text = "Azuriraj listu";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // goBackButtonSimulator
            // 
            this.goBackButtonSimulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goBackButtonSimulator.BackgroundImage")));
            this.goBackButtonSimulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goBackButtonSimulator.Location = new System.Drawing.Point(12, 464);
            this.goBackButtonSimulator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goBackButtonSimulator.Name = "goBackButtonSimulator";
            this.goBackButtonSimulator.Size = new System.Drawing.Size(69, 64);
            this.goBackButtonSimulator.TabIndex = 42;
            this.goBackButtonSimulator.Click += new System.EventHandler(this.goBackButtonSimulator_Click);
            // 
            // idrezervacijaDataGridViewTextBoxColumn
            // 
            this.idrezervacijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idrezervacijaDataGridViewTextBoxColumn.DataPropertyName = "id_rezervacija";
            this.idrezervacijaDataGridViewTextBoxColumn.HeaderText = "Id rezervacije";
            this.idrezervacijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrezervacijaDataGridViewTextBoxColumn.Name = "idrezervacijaDataGridViewTextBoxColumn";
            this.idrezervacijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvozilaDataGridViewTextBoxColumn
            // 
            this.idvozilaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idvozilaDataGridViewTextBoxColumn.DataPropertyName = "id_vozila";
            this.idvozilaDataGridViewTextBoxColumn.HeaderText = "Id vozila";
            this.idvozilaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvozilaDataGridViewTextBoxColumn.Name = "idvozilaDataGridViewTextBoxColumn";
            this.idvozilaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idklijentaDataGridViewTextBoxColumn
            // 
            this.idklijentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idklijentaDataGridViewTextBoxColumn.DataPropertyName = "id_klijenta";
            this.idklijentaDataGridViewTextBoxColumn.HeaderText = "Id klijenta";
            this.idklijentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklijentaDataGridViewTextBoxColumn.Name = "idklijentaDataGridViewTextBoxColumn";
            this.idklijentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumVremepocetkaDataGridViewTextBoxColumn
            // 
            this.datumVremepocetkaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumVremepocetkaDataGridViewTextBoxColumn.DataPropertyName = "datumVreme_pocetka";
            this.datumVremepocetkaDataGridViewTextBoxColumn.HeaderText = "Početak rezervacije";
            this.datumVremepocetkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumVremepocetkaDataGridViewTextBoxColumn.Name = "datumVremepocetkaDataGridViewTextBoxColumn";
            this.datumVremepocetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumVremekrajaDataGridViewTextBoxColumn
            // 
            this.datumVremekrajaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumVremekrajaDataGridViewTextBoxColumn.DataPropertyName = "datumVreme_kraja";
            this.datumVremekrajaDataGridViewTextBoxColumn.HeaderText = "Kraj rezervacije";
            this.datumVremekrajaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumVremekrajaDataGridViewTextBoxColumn.Name = "datumVremekrajaDataGridViewTextBoxColumn";
            this.datumVremekrajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.dtpKrajPrikaz);
            this.panel1.Controls.Add(this.dtpPocetakPrikaz);
            this.panel1.Controls.Add(this.lblIzvestaj);
            this.panel1.Controls.Add(this.lblOdDo);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 116);
            this.panel1.TabIndex = 43;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(760, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goBackButtonSimulator);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.dataGridViewRezervacija);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewRezervacija;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpPocetakPrikaz;
        private System.Windows.Forms.DateTimePicker dtpKrajPrikaz;
        private System.Windows.Forms.Label lblIzvestaj;
        private System.Windows.Forms.Label lblOdDo;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private RentACarDataSetTableAdapters.RezervacijaTableAdapter rezervacijaTableAdapter;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Panel goBackButtonSimulator;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVremepocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVremekrajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}