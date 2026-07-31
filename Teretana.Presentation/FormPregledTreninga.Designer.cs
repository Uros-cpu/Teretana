namespace Teretana.Presentation
{
    partial class FormPregledTreninga
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.btnMojiTreninzi = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTreninzi
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvTreninzi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTreninzi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreninzi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(24, 111);
            this.dgvTreninzi.MultiSelect = false;
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreninzi.Size = new System.Drawing.Size(731, 179);
            this.dgvTreninzi.TabIndex = 0;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.Color.Teal;
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.Cyan;
            this.btnPrijaviSe.Location = new System.Drawing.Point(58, 363);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(150, 35);
            this.btnPrijaviSe.TabIndex = 1;
            this.btnPrijaviSe.Text = "Prijavi se na trening";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // btnMojiTreninzi
            // 
            this.btnMojiTreninzi.BackColor = System.Drawing.Color.Green;
            this.btnMojiTreninzi.ForeColor = System.Drawing.Color.Lime;
            this.btnMojiTreninzi.Location = new System.Drawing.Point(315, 363);
            this.btnMojiTreninzi.Name = "btnMojiTreninzi";
            this.btnMojiTreninzi.Size = new System.Drawing.Size(150, 35);
            this.btnMojiTreninzi.TabIndex = 2;
            this.btnMojiTreninzi.Text = "Moji treninzi";
            this.btnMojiTreninzi.UseVisualStyleBackColor = false;
            this.btnMojiTreninzi.Click += new System.EventHandler(this.btnMojiTreninzi_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Maroon;
            this.btnOdjava.ForeColor = System.Drawing.Color.Red;
            this.btnOdjava.Location = new System.Drawing.Point(574, 363);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(150, 35);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(80, 195);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 16);
            this.lblPoruka.TabIndex = 4;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(24, 34);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(303, 29);
            this.lblDobrodosli.TabIndex = 5;
            this.lblDobrodosli.Text = "Pregled dostupnih treninga";
            // 
            // FormPregledTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnMojiTreninzi);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.dgvTreninzi);
            this.Name = "FormPregledTreninga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teretana - Pregled treninga";
            this.Load += new System.EventHandler(this.FormPregledTreninga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Button btnMojiTreninzi;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Label lblDobrodosli;
    }
}