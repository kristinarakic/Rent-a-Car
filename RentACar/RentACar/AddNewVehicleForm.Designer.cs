namespace RentACar
{
    partial class AddNewVehicleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewVehicleForm));
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cmbKategorijaVozilo = new System.Windows.Forms.ComboBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMarkaVozilo = new System.Windows.Forms.TextBox();
            this.txtModelVozilo = new System.Windows.Forms.TextBox();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.lblErrorNazivVozilo = new System.Windows.Forms.Label();
            this.lblErrorMarkaVozilo = new System.Windows.Forms.Label();
            this.lblErrorGodinaVozilo = new System.Windows.Forms.Label();
            this.lblErrorModelVozilo = new System.Windows.Forms.Label();
            this.pnlNazadDugmeSimulator = new System.Windows.Forms.Panel();
            this.lblCenaPoSatu = new System.Windows.Forms.Label();
            this.txtCenaPoSatu = new System.Windows.Forms.TextBox();
            this.lblErrorCenaVozilo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(162, 35);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(92, 20);
            this.lblKategorija.TabIndex = 0;
            this.lblKategorija.Text = "Kategorija: ";
            // 
            // cmbKategorijaVozilo
            // 
            this.cmbKategorijaVozilo.FormattingEnabled = true;
            this.cmbKategorijaVozilo.Location = new System.Drawing.Point(260, 32);
            this.cmbKategorijaVozilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKategorijaVozilo.Name = "cmbKategorijaVozilo";
            this.cmbKategorijaVozilo.Size = new System.Drawing.Size(136, 28);
            this.cmbKategorijaVozilo.TabIndex = 1;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(193, 98);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(53, 20);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(260, 98);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(136, 26);
            this.txtNaziv.TabIndex = 3;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(185, 169);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(61, 20);
            this.lblMarka.TabIndex = 4;
            this.lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(185, 235);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(61, 20);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model:";
            // 
            // txtMarkaVozilo
            // 
            this.txtMarkaVozilo.Location = new System.Drawing.Point(260, 169);
            this.txtMarkaVozilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarkaVozilo.Name = "txtMarkaVozilo";
            this.txtMarkaVozilo.Size = new System.Drawing.Size(136, 26);
            this.txtMarkaVozilo.TabIndex = 6;
            // 
            // txtModelVozilo
            // 
            this.txtModelVozilo.Location = new System.Drawing.Point(260, 232);
            this.txtModelVozilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelVozilo.Name = "txtModelVozilo";
            this.txtModelVozilo.Size = new System.Drawing.Size(136, 26);
            this.txtModelVozilo.TabIndex = 7;
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(88, 301);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(158, 20);
            this.lblGodinaProizvodnje.TabIndex = 8;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje:";
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(260, 295);
            this.txtGodinaProizvodnje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(136, 26);
            this.txtGodinaProizvodnje.TabIndex = 9;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodajVozilo.ForeColor = System.Drawing.Color.Green;
            this.btnDodajVozilo.Location = new System.Drawing.Point(219, 438);
            this.btnDodajVozilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(123, 48);
            this.btnDodajVozilo.TabIndex = 10;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // lblErrorNazivVozilo
            // 
            this.lblErrorNazivVozilo.AutoSize = true;
            this.lblErrorNazivVozilo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorNazivVozilo.Location = new System.Drawing.Point(256, 128);
            this.lblErrorNazivVozilo.Name = "lblErrorNazivVozilo";
            this.lblErrorNazivVozilo.Size = new System.Drawing.Size(86, 20);
            this.lblErrorNazivVozilo.TabIndex = 11;
            this.lblErrorNazivVozilo.Text = "error naziv";
            this.lblErrorNazivVozilo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorNazivVozilo.Visible = false;
            // 
            // lblErrorMarkaVozilo
            // 
            this.lblErrorMarkaVozilo.AutoSize = true;
            this.lblErrorMarkaVozilo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorMarkaVozilo.Location = new System.Drawing.Point(256, 199);
            this.lblErrorMarkaVozilo.Name = "lblErrorMarkaVozilo";
            this.lblErrorMarkaVozilo.Size = new System.Drawing.Size(94, 20);
            this.lblErrorMarkaVozilo.TabIndex = 12;
            this.lblErrorMarkaVozilo.Text = "error marka";
            this.lblErrorMarkaVozilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMarkaVozilo.Visible = false;
            // 
            // lblErrorGodinaVozilo
            // 
            this.lblErrorGodinaVozilo.AutoSize = true;
            this.lblErrorGodinaVozilo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorGodinaVozilo.Location = new System.Drawing.Point(256, 325);
            this.lblErrorGodinaVozilo.Name = "lblErrorGodinaVozilo";
            this.lblErrorGodinaVozilo.Size = new System.Drawing.Size(100, 20);
            this.lblErrorGodinaVozilo.TabIndex = 14;
            this.lblErrorGodinaVozilo.Text = "error godina";
            this.lblErrorGodinaVozilo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorGodinaVozilo.Visible = false;
            // 
            // lblErrorModelVozilo
            // 
            this.lblErrorModelVozilo.AutoSize = true;
            this.lblErrorModelVozilo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorModelVozilo.Location = new System.Drawing.Point(256, 262);
            this.lblErrorModelVozilo.Name = "lblErrorModelVozilo";
            this.lblErrorModelVozilo.Size = new System.Drawing.Size(94, 20);
            this.lblErrorModelVozilo.TabIndex = 15;
            this.lblErrorModelVozilo.Text = "error model";
            this.lblErrorModelVozilo.Visible = false;
            // 
            // pnlNazadDugmeSimulator
            // 
            this.pnlNazadDugmeSimulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNazadDugmeSimulator.BackgroundImage")));
            this.pnlNazadDugmeSimulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNazadDugmeSimulator.Location = new System.Drawing.Point(28, 438);
            this.pnlNazadDugmeSimulator.Name = "pnlNazadDugmeSimulator";
            this.pnlNazadDugmeSimulator.Size = new System.Drawing.Size(65, 63);
            this.pnlNazadDugmeSimulator.TabIndex = 19;
            this.pnlNazadDugmeSimulator.Click += new System.EventHandler(this.pnlNazadDugmeSimulator_Click);
            // 
            // lblCenaPoSatu
            // 
            this.lblCenaPoSatu.AutoSize = true;
            this.lblCenaPoSatu.Location = new System.Drawing.Point(134, 363);
            this.lblCenaPoSatu.Name = "lblCenaPoSatu";
            this.lblCenaPoSatu.Size = new System.Drawing.Size(112, 20);
            this.lblCenaPoSatu.TabIndex = 16;
            this.lblCenaPoSatu.Text = "Cena po satu:";
            // 
            // txtCenaPoSatu
            // 
            this.txtCenaPoSatu.Location = new System.Drawing.Point(260, 360);
            this.txtCenaPoSatu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCenaPoSatu.Name = "txtCenaPoSatu";
            this.txtCenaPoSatu.Size = new System.Drawing.Size(136, 26);
            this.txtCenaPoSatu.TabIndex = 17;
            // 
            // lblErrorCenaVozilo
            // 
            this.lblErrorCenaVozilo.AutoSize = true;
            this.lblErrorCenaVozilo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorCenaVozilo.Location = new System.Drawing.Point(256, 390);
            this.lblErrorCenaVozilo.Name = "lblErrorCenaVozilo";
            this.lblErrorCenaVozilo.Size = new System.Drawing.Size(87, 20);
            this.lblErrorCenaVozilo.TabIndex = 18;
            this.lblErrorCenaVozilo.Text = "error cena";
            this.lblErrorCenaVozilo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorCenaVozilo.Visible = false;
            // 
            // AddNewVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(538, 501);
            this.Controls.Add(this.pnlNazadDugmeSimulator);
            this.Controls.Add(this.lblErrorCenaVozilo);
            this.Controls.Add(this.txtCenaPoSatu);
            this.Controls.Add(this.lblCenaPoSatu);
            this.Controls.Add(this.lblErrorModelVozilo);
            this.Controls.Add(this.lblErrorGodinaVozilo);
            this.Controls.Add(this.lblErrorMarkaVozilo);
            this.Controls.Add(this.lblErrorNazivVozilo);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.lblGodinaProizvodnje);
            this.Controls.Add(this.txtModelVozilo);
            this.Controls.Add(this.txtMarkaVozilo);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.cmbKategorijaVozilo);
            this.Controls.Add(this.lblKategorija);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddNewVehicleForm";
            this.Text = "AddNewVehicle";
            this.Load += new System.EventHandler(this.AddNewVehicleForm_Load);
            this.TextChanged += new System.EventHandler(this.AddNewVehicle_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cmbKategorijaVozilo;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtMarkaVozilo;
        private System.Windows.Forms.TextBox txtModelVozilo;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Label lblErrorNazivVozilo;
        private System.Windows.Forms.Label lblErrorMarkaVozilo;
        private System.Windows.Forms.Label lblErrorGodinaVozilo;
        private System.Windows.Forms.Label lblErrorModelVozilo;
        private System.Windows.Forms.Panel pnlNazadDugmeSimulator;
        private System.Windows.Forms.Label lblCenaPoSatu;
        private System.Windows.Forms.TextBox txtCenaPoSatu;
        private System.Windows.Forms.Label lblErrorCenaVozilo;
    }
}