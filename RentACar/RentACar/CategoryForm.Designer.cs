namespace RentACar
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.goBackButtonSimulator = new System.Windows.Forms.Panel();
            this.lblErrorOpisKategorija = new System.Windows.Forms.Label();
            this.lblErrorNazivKategorija = new System.Windows.Forms.Label();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.txtOpisKategorija = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtNazivKategorija = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dataGridViewKategorija = new System.Windows.Forms.DataGridView();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.kategorijaTableAdapter = new RentACar.RentACarDataSetTableAdapters.KategorijaTableAdapter();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategorijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goBackButtonSimulator
            // 
            this.goBackButtonSimulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goBackButtonSimulator.BackgroundImage")));
            this.goBackButtonSimulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goBackButtonSimulator.Location = new System.Drawing.Point(12, 310);
            this.goBackButtonSimulator.Name = "goBackButtonSimulator";
            this.goBackButtonSimulator.Size = new System.Drawing.Size(67, 64);
            this.goBackButtonSimulator.TabIndex = 38;
            this.goBackButtonSimulator.Click += new System.EventHandler(this.goBackButtonSimulator_Click);
            // 
            // lblErrorOpisKategorija
            // 
            this.lblErrorOpisKategorija.AutoSize = true;
            this.lblErrorOpisKategorija.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOpisKategorija.Location = new System.Drawing.Point(127, 193);
            this.lblErrorOpisKategorija.Name = "lblErrorOpisKategorija";
            this.lblErrorOpisKategorija.Size = new System.Drawing.Size(77, 20);
            this.lblErrorOpisKategorija.TabIndex = 32;
            this.lblErrorOpisKategorija.Text = "error opis";
            this.lblErrorOpisKategorija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorOpisKategorija.Visible = false;
            // 
            // lblErrorNazivKategorija
            // 
            this.lblErrorNazivKategorija.AutoSize = true;
            this.lblErrorNazivKategorija.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNazivKategorija.Location = new System.Drawing.Point(134, 112);
            this.lblErrorNazivKategorija.Name = "lblErrorNazivKategorija";
            this.lblErrorNazivKategorija.Size = new System.Drawing.Size(86, 20);
            this.lblErrorNazivKategorija.TabIndex = 31;
            this.lblErrorNazivKategorija.Text = "error naziv";
            this.lblErrorNazivKategorija.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorNazivKategorija.Visible = false;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajKategoriju.ForeColor = System.Drawing.Color.Green;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(98, 315);
            this.btnDodajKategoriju.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(158, 51);
            this.btnDodajKategoriju.TabIndex = 30;
            this.btnDodajKategoriju.Text = "Dodaj kateogoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = false;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // txtOpisKategorija
            // 
            this.txtOpisKategorija.Location = new System.Drawing.Point(131, 163);
            this.txtOpisKategorija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpisKategorija.Name = "txtOpisKategorija";
            this.txtOpisKategorija.Size = new System.Drawing.Size(152, 26);
            this.txtOpisKategorija.TabIndex = 26;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOpis.Location = new System.Drawing.Point(64, 163);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(45, 20);
            this.lblOpis.TabIndex = 24;
            this.lblOpis.Text = "Opis:";
            // 
            // txtNazivKategorija
            // 
            this.txtNazivKategorija.Location = new System.Drawing.Point(131, 82);
            this.txtNazivKategorija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNazivKategorija.Name = "txtNazivKategorija";
            this.txtNazivKategorija.Size = new System.Drawing.Size(152, 26);
            this.txtNazivKategorija.TabIndex = 23;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNaziv.Location = new System.Drawing.Point(56, 82);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(53, 20);
            this.lblNaziv.TabIndex = 22;
            this.lblNaziv.Text = "Naziv:";
            // 
            // dataGridViewKategorija
            // 
            this.dataGridViewKategorija.AllowUserToAddRows = false;
            this.dataGridViewKategorija.AllowUserToDeleteRows = false;
            this.dataGridViewKategorija.AutoGenerateColumns = false;
            this.dataGridViewKategorija.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkategorijeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridViewKategorija.DataSource = this.kategorijaBindingSource;
            this.dataGridViewKategorija.Location = new System.Drawing.Point(-1, -2);
            this.dataGridViewKategorija.Name = "dataGridViewKategorija";
            this.dataGridViewKategorija.RowHeadersWidth = 51;
            this.dataGridViewKategorija.RowTemplate.Height = 24;
            this.dataGridViewKategorija.Size = new System.Drawing.Size(541, 306);
            this.dataGridViewKategorija.TabIndex = 40;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this.rentACarDataSet;
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.Frozen = true;
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // idkategorijeDataGridViewTextBoxColumn
            // 
            this.idkategorijeDataGridViewTextBoxColumn.DataPropertyName = "id_kategorije";
            this.idkategorijeDataGridViewTextBoxColumn.Frozen = true;
            this.idkategorijeDataGridViewTextBoxColumn.HeaderText = "Id kategorije";
            this.idkategorijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkategorijeDataGridViewTextBoxColumn.Name = "idkategorijeDataGridViewTextBoxColumn";
            this.idkategorijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.txtOpisKategorija);
            this.panel1.Controls.Add(this.lblNaziv);
            this.panel1.Controls.Add(this.txtNazivKategorija);
            this.panel1.Controls.Add(this.lblOpis);
            this.panel1.Controls.Add(this.lblErrorOpisKategorija);
            this.panel1.Controls.Add(this.btnDodajKategoriju);
            this.panel1.Controls.Add(this.lblErrorNazivKategorija);
            this.panel1.Location = new System.Drawing.Point(537, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 396);
            this.panel1.TabIndex = 41;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(862, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewKategorija);
            this.Controls.Add(this.goBackButtonSimulator);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "AddNewCategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.TextChanged += new System.EventHandler(this.CategoryForm_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel goBackButtonSimulator;
        private System.Windows.Forms.Label lblErrorOpisKategorija;
        private System.Windows.Forms.Label lblErrorNazivKategorija;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.TextBox txtOpisKategorija;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtNazivKategorija;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dataGridViewKategorija;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private RentACarDataSetTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategorijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}