namespace Teretana.Presentation
{
    partial class FormMojiTreninzi
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
            this.dgvMojiTreninzi = new System.Windows.Forms.DataGridView();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojiTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMojiTreninzi
            // 
            this.dgvMojiTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMojiTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojiTreninzi.Location = new System.Drawing.Point(23, 24);
            this.dgvMojiTreninzi.MultiSelect = false;
            this.dgvMojiTreninzi.Name = "dgvMojiTreninzi";
            this.dgvMojiTreninzi.ReadOnly = true;
            this.dgvMojiTreninzi.RowHeadersWidth = 51;
            this.dgvMojiTreninzi.RowTemplate.Height = 24;
            this.dgvMojiTreninzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMojiTreninzi.Size = new System.Drawing.Size(745, 201);
            this.dgvMojiTreninzi.TabIndex = 0;
            this.dgvMojiTreninzi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMojiTreninzi_CellFormatting);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.Maroon;
            this.btnOtkazi.ForeColor = System.Drawing.Color.Red;
            this.btnOtkazi.Location = new System.Drawing.Point(206, 295);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(150, 35);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkazi prijavu";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.Teal;
            this.btnNazad.ForeColor = System.Drawing.Color.Cyan;
            this.btnNazad.Location = new System.Drawing.Point(410, 295);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(150, 35);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(430, 246);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 16);
            this.lblPoruka.TabIndex = 3;
            // 
            // FormMojiTreninzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.dgvMojiTreninzi);
            this.Name = "FormMojiTreninzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teretana - Moji treninzi";
            this.Load += new System.EventHandler(this.FormMojiTreninzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojiTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMojiTreninzi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label lblPoruka;
    }
}