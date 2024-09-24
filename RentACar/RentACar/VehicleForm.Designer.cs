namespace RentACar
{
    partial class VehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleForm));
            this.dataGridViewVozilo = new System.Windows.Forms.DataGridView();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.nazadDugmeSimulator = new System.Windows.Forms.Panel();
            this.voziloTableAdapter = new RentACar.RentACarDataSetTableAdapters.VoziloTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.idvozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaproizvodnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaposatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinCena = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxCena = new System.Windows.Forms.Label();
            this.dtpDatumKraj = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDatumPocetak = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCena)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVozilo
            // 
            this.dataGridViewVozilo.AllowUserToAddRows = false;
            this.dataGridViewVozilo.AllowUserToDeleteRows = false;
            this.dataGridViewVozilo.AutoGenerateColumns = false;
            this.dataGridViewVozilo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewVozilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVozilo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvozilaDataGridViewTextBoxColumn,
            this.idkategorijeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.godinaproizvodnjeDataGridViewTextBoxColumn,
            this.cenaposatuDataGridViewTextBoxColumn});
            this.dataGridViewVozilo.DataSource = this.voziloBindingSource;
            this.dataGridViewVozilo.Location = new System.Drawing.Point(0, 174);
            this.dataGridViewVozilo.Name = "dataGridViewVozilo";
            this.dataGridViewVozilo.RowHeadersWidth = 51;
            this.dataGridViewVozilo.RowTemplate.Height = 24;
            this.dataGridViewVozilo.Size = new System.Drawing.Size(1010, 290);
            this.dataGridViewVozilo.TabIndex = 1;
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataMember = "Vozilo";
            this.voziloBindingSource.DataSource = this.rentACarDataSet;
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(33, 84);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(164, 25);
            this.cmbKategorija.TabIndex = 2;
            this.cmbKategorija.SelectedValueChanged += new System.EventHandler(this.cmbKategorija_SelectedValueChanged);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.White;
            this.btnDodajVozilo.ForeColor = System.Drawing.Color.Green;
            this.btnDodajVozilo.Location = new System.Drawing.Point(428, 9);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(138, 44);
            this.btnDodajVozilo.TabIndex = 3;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // nazadDugmeSimulator
            // 
            this.nazadDugmeSimulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nazadDugmeSimulator.BackgroundImage")));
            this.nazadDugmeSimulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nazadDugmeSimulator.Location = new System.Drawing.Point(17, 9);
            this.nazadDugmeSimulator.Name = "nazadDugmeSimulator";
            this.nazadDugmeSimulator.Size = new System.Drawing.Size(60, 59);
            this.nazadDugmeSimulator.TabIndex = 20;
            this.nazadDugmeSimulator.Click += new System.EventHandler(this.nazadDugmeSimulator_Click);
            // 
            // voziloTableAdapter
            // 
            this.voziloTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Kategoriji:";
            // 
            // idvozilaDataGridViewTextBoxColumn
            // 
            this.idvozilaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idvozilaDataGridViewTextBoxColumn.DataPropertyName = "id_vozila";
            this.idvozilaDataGridViewTextBoxColumn.HeaderText = "Id vozila";
            this.idvozilaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvozilaDataGridViewTextBoxColumn.Name = "idvozilaDataGridViewTextBoxColumn";
            // 
            // idkategorijeDataGridViewTextBoxColumn
            // 
            this.idkategorijeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idkategorijeDataGridViewTextBoxColumn.DataPropertyName = "id_kategorije";
            this.idkategorijeDataGridViewTextBoxColumn.HeaderText = "Id kategorije";
            this.idkategorijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkategorijeDataGridViewTextBoxColumn.Name = "idkategorijeDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // godinaproizvodnjeDataGridViewTextBoxColumn
            // 
            this.godinaproizvodnjeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.godinaproizvodnjeDataGridViewTextBoxColumn.DataPropertyName = "godina_proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.HeaderText = "Godina proizvodnje";
            this.godinaproizvodnjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.godinaproizvodnjeDataGridViewTextBoxColumn.Name = "godinaproizvodnjeDataGridViewTextBoxColumn";
            // 
            // cenaposatuDataGridViewTextBoxColumn
            // 
            this.cenaposatuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cenaposatuDataGridViewTextBoxColumn.DataPropertyName = "cena_po_satu";
            this.cenaposatuDataGridViewTextBoxColumn.HeaderText = "Cena po satu";
            this.cenaposatuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaposatuDataGridViewTextBoxColumn.Name = "cenaposatuDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.dtpDatumPocetak);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbKategorija);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbCena);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpDatumKraj);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMaxCena);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblMinCena);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 177);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(414, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Filtriraj vozila po:";
            // 
            // lblMinCena
            // 
            this.lblMinCena.AutoSize = true;
            this.lblMinCena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMinCena.Location = new System.Drawing.Point(258, 143);
            this.lblMinCena.Name = "lblMinCena";
            this.lblMinCena.Size = new System.Drawing.Size(15, 17);
            this.lblMinCena.TabIndex = 25;
            this.lblMinCena.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 27;
            // 
            // lblMaxCena
            // 
            this.lblMaxCena.AutoSize = true;
            this.lblMaxCena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMaxCena.Location = new System.Drawing.Point(434, 143);
            this.lblMaxCena.Name = "lblMaxCena";
            this.lblMaxCena.Size = new System.Drawing.Size(47, 17);
            this.lblMaxCena.TabIndex = 24;
            this.lblMaxCena.Text = "label1";
            // 
            // dtpDatumKraj
            // 
            this.dtpDatumKraj.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpDatumKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumKraj.Location = new System.Drawing.Point(771, 94);
            this.dtpDatumKraj.MinDate = new System.DateTime(2024, 9, 17, 0, 0, 0, 0);
            this.dtpDatumKraj.Name = "dtpDatumKraj";
            this.dtpDatumKraj.Size = new System.Drawing.Size(200, 23);
            this.dtpDatumKraj.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(258, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Opsegu cene:";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(248, 84);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(223, 56);
            this.tbCena.TabIndex = 21;
            this.tbCena.Scroll += new System.EventHandler(this.tbCena_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(681, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Dostupnosti u periodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "-";
            // 
            // dtpDatumPocetak
            // 
            this.dtpDatumPocetak.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpDatumPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPocetak.Location = new System.Drawing.Point(541, 94);
            this.dtpDatumPocetak.MinDate = new System.DateTime(2024, 9, 17, 0, 0, 0, 0);
            this.dtpDatumPocetak.Name = "dtpDatumPocetak";
            this.dtpDatumPocetak.Size = new System.Drawing.Size(200, 23);
            this.dtpDatumPocetak.TabIndex = 23;
            this.dtpDatumPocetak.ValueChanged += new System.EventHandler(this.dtpDatumPocetak_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDodajVozilo);
            this.panel2.Controls.Add(this.nazadDugmeSimulator);
            this.panel2.Location = new System.Drawing.Point(0, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 87);
            this.panel2.TabIndex = 33;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1008, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewVozilo);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCena)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVozilo;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private RentACarDataSetTableAdapters.VoziloTableAdapter voziloTableAdapter;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Panel nazadDugmeSimulator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaproizvodnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaposatuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumKraj;
        private System.Windows.Forms.Label lblMaxCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}