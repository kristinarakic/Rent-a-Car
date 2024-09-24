namespace RentACar
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnKategorije = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.lblNajpopularnijeVozilo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKategorije
            // 
            this.btnKategorije.BackColor = System.Drawing.Color.White;
            this.btnKategorije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKategorije.ForeColor = System.Drawing.Color.Purple;
            this.btnKategorije.Location = new System.Drawing.Point(483, 191);
            this.btnKategorije.Margin = new System.Windows.Forms.Padding(0);
            this.btnKategorije.Name = "btnKategorije";
            this.btnKategorije.Size = new System.Drawing.Size(168, 45);
            this.btnKategorije.TabIndex = 0;
            this.btnKategorije.Text = "Kategorije";
            this.btnKategorije.UseVisualStyleBackColor = false;
            this.btnKategorije.Click += new System.EventHandler(this.btnKategorije_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.BackColor = System.Drawing.Color.White;
            this.btnVozila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVozila.ForeColor = System.Drawing.Color.Purple;
            this.btnVozila.Location = new System.Drawing.Point(483, 102);
            this.btnVozila.Margin = new System.Windows.Forms.Padding(0);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(168, 45);
            this.btnVozila.TabIndex = 1;
            this.btnVozila.Text = "Vozila";
            this.btnVozila.UseVisualStyleBackColor = false;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(483, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Korisnici";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.BackColor = System.Drawing.Color.White;
            this.btnRezervacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRezervacije.ForeColor = System.Drawing.Color.Purple;
            this.btnRezervacije.Location = new System.Drawing.Point(483, 370);
            this.btnRezervacije.Margin = new System.Windows.Forms.Padding(0);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(168, 45);
            this.btnRezervacije.TabIndex = 3;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = false;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // lblNajpopularnijeVozilo
            // 
            this.lblNajpopularnijeVozilo.AutoSize = true;
            this.lblNajpopularnijeVozilo.Font = new System.Drawing.Font("Copperplate Gothic Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNajpopularnijeVozilo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNajpopularnijeVozilo.Location = new System.Drawing.Point(54, 254);
            this.lblNajpopularnijeVozilo.Name = "lblNajpopularnijeVozilo";
            this.lblNajpopularnijeVozilo.Size = new System.Drawing.Size(117, 30);
            this.lblNajpopularnijeVozilo.TabIndex = 4;
            this.lblNajpopularnijeVozilo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Najpopularnije vozilo:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(644, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 44);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.lblNajpopularnijeVozilo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 512);
            this.panel2.TabIndex = 7;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnKategorije);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategorije;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Label lblNajpopularnijeVozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}