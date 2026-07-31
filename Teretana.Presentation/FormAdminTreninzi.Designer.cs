namespace Teretana.Presentation
{
    partial class FormAdminTreninzi
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
            this.dgvAdminTreninzi = new System.Windows.Forms.DataGridView();
            this.lblPodaciOTreningu = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTrener = new System.Windows.Forms.TextBox();
            this.txtTipTreninga = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtMaxUcesnika = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblTrener = new System.Windows.Forms.Label();
            this.lblTipTreninga = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblMaxUcesnika = new System.Windows.Forms.Label();
            this.lblDatumVreme = new System.Windows.Forms.Label();
            this.dtpDatumTermina = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminTreninzi
            // 
            this.dgvAdminTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminTreninzi.Location = new System.Drawing.Point(12, 22);
            this.dgvAdminTreninzi.Name = "dgvAdminTreninzi";
            this.dgvAdminTreninzi.RowHeadersWidth = 51;
            this.dgvAdminTreninzi.RowTemplate.Height = 24;
            this.dgvAdminTreninzi.Size = new System.Drawing.Size(858, 144);
            this.dgvAdminTreninzi.TabIndex = 0;
            this.dgvAdminTreninzi.SelectionChanged += new System.EventHandler(this.dgvAdminTreninzi_SelectionChanged);
            // 
            // lblPodaciOTreningu
            // 
            this.lblPodaciOTreningu.AutoSize = true;
            this.lblPodaciOTreningu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaciOTreningu.Location = new System.Drawing.Point(13, 182);
            this.lblPodaciOTreningu.Name = "lblPodaciOTreningu";
            this.lblPodaciOTreningu.Size = new System.Drawing.Size(163, 25);
            this.lblPodaciOTreningu.TabIndex = 1;
            this.lblPodaciOTreningu.Text = "Podaci o treningu";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(181, 235);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(222, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtTrener
            // 
            this.txtTrener.Location = new System.Drawing.Point(480, 235);
            this.txtTrener.Name = "txtTrener";
            this.txtTrener.Size = new System.Drawing.Size(222, 22);
            this.txtTrener.TabIndex = 3;
            // 
            // txtTipTreninga
            // 
            this.txtTipTreninga.Location = new System.Drawing.Point(181, 298);
            this.txtTipTreninga.Name = "txtTipTreninga";
            this.txtTipTreninga.Size = new System.Drawing.Size(222, 22);
            this.txtTipTreninga.TabIndex = 4;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(480, 298);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(222, 22);
            this.txtTrajanje.TabIndex = 5;
            // 
            // txtMaxUcesnika
            // 
            this.txtMaxUcesnika.Location = new System.Drawing.Point(181, 358);
            this.txtMaxUcesnika.Name = "txtMaxUcesnika";
            this.txtMaxUcesnika.Size = new System.Drawing.Size(222, 22);
            this.txtMaxUcesnika.TabIndex = 6;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(181, 211);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(41, 16);
            this.lblNaziv.TabIndex = 8;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblTrener
            // 
            this.lblTrener.AutoSize = true;
            this.lblTrener.Location = new System.Drawing.Point(480, 211);
            this.lblTrener.Name = "lblTrener";
            this.lblTrener.Size = new System.Drawing.Size(47, 16);
            this.lblTrener.TabIndex = 9;
            this.lblTrener.Text = "Trener";
            // 
            // lblTipTreninga
            // 
            this.lblTipTreninga.AutoSize = true;
            this.lblTipTreninga.Location = new System.Drawing.Point(181, 276);
            this.lblTipTreninga.Name = "lblTipTreninga";
            this.lblTipTreninga.Size = new System.Drawing.Size(78, 16);
            this.lblTipTreninga.TabIndex = 10;
            this.lblTipTreninga.Text = "Tip treninga";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(480, 276);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(89, 16);
            this.lblTrajanje.TabIndex = 11;
            this.lblTrajanje.Text = "Trajanje (min)";
            // 
            // lblMaxUcesnika
            // 
            this.lblMaxUcesnika.AutoSize = true;
            this.lblMaxUcesnika.Location = new System.Drawing.Point(184, 336);
            this.lblMaxUcesnika.Name = "lblMaxUcesnika";
            this.lblMaxUcesnika.Size = new System.Drawing.Size(115, 16);
            this.lblMaxUcesnika.TabIndex = 12;
            this.lblMaxUcesnika.Text = "Max broj ucesnika";
            // 
            // lblDatumVreme
            // 
            this.lblDatumVreme.AutoSize = true;
            this.lblDatumVreme.Location = new System.Drawing.Point(480, 335);
            this.lblDatumVreme.Name = "lblDatumVreme";
            this.lblDatumVreme.Size = new System.Drawing.Size(140, 16);
            this.lblDatumVreme.TabIndex = 13;
            this.lblDatumVreme.Text = "Datum i vreme termina";
            // 
            // dtpDatumTermina
            // 
            this.dtpDatumTermina.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatumTermina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumTermina.Location = new System.Drawing.Point(480, 356);
            this.dtpDatumTermina.Name = "dtpDatumTermina";
            this.dtpDatumTermina.ShowUpDown = true;
            this.dtpDatumTermina.Size = new System.Drawing.Size(222, 22);
            this.dtpDatumTermina.TabIndex = 14;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Green;
            this.btnDodaj.ForeColor = System.Drawing.Color.Lime;
            this.btnDodaj.Location = new System.Drawing.Point(372, 406);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 35);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.Teal;
            this.btnIzmeni.ForeColor = System.Drawing.Color.Cyan;
            this.btnIzmeni.Location = new System.Drawing.Point(498, 406);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(120, 35);
            this.btnIzmeni.TabIndex = 16;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Maroon;
            this.btnObrisi.ForeColor = System.Drawing.Color.Red;
            this.btnObrisi.Location = new System.Drawing.Point(624, 406);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(120, 35);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(750, 406);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(120, 35);
            this.btnZatvori.TabIndex = 18;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPoruka.Location = new System.Drawing.Point(57, 387);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 16);
            this.lblPoruka.TabIndex = 19;
            // 
            // FormAdminTreninzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpDatumTermina);
            this.Controls.Add(this.lblDatumVreme);
            this.Controls.Add(this.lblMaxUcesnika);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.lblTipTreninga);
            this.Controls.Add(this.lblTrener);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtMaxUcesnika);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtTipTreninga);
            this.Controls.Add(this.txtTrener);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblPodaciOTreningu);
            this.Controls.Add(this.dgvAdminTreninzi);
            this.MaximizeBox = false;
            this.Name = "FormAdminTreninzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teretana - Admin treninzi";
            this.Load += new System.EventHandler(this.FormAdminTreninzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminTreninzi;
        private System.Windows.Forms.Label lblPodaciOTreningu;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtTrener;
        private System.Windows.Forms.TextBox txtTipTreninga;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtMaxUcesnika;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblTrener;
        private System.Windows.Forms.Label lblTipTreninga;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblMaxUcesnika;
        private System.Windows.Forms.Label lblDatumVreme;
        private System.Windows.Forms.DateTimePicker dtpDatumTermina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label lblPoruka;
    }
}