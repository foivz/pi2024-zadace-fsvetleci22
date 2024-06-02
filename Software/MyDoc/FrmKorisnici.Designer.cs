namespace MyDoc
{
    partial class FrmKorisnici
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPovratakKorisnik = new System.Windows.Forms.Button();
            this.lblPopisKorisnikaNaslov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(29, 123);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(740, 381);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // btnPovratakKorisnik
            // 
            this.btnPovratakKorisnik.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPovratakKorisnik.Location = new System.Drawing.Point(29, 12);
            this.btnPovratakKorisnik.Name = "btnPovratakKorisnik";
            this.btnPovratakKorisnik.Size = new System.Drawing.Size(86, 44);
            this.btnPovratakKorisnik.TabIndex = 4;
            this.btnPovratakKorisnik.Text = "VRATI SE";
            this.btnPovratakKorisnik.UseVisualStyleBackColor = false;
            this.btnPovratakKorisnik.Click += new System.EventHandler(this.btnPovratakKorisnik_Click);
            // 
            // lblPopisKorisnikaNaslov
            // 
            this.lblPopisKorisnikaNaslov.AutoSize = true;
            this.lblPopisKorisnikaNaslov.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPopisKorisnikaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPopisKorisnikaNaslov.Location = new System.Drawing.Point(254, 33);
            this.lblPopisKorisnikaNaslov.Name = "lblPopisKorisnikaNaslov";
            this.lblPopisKorisnikaNaslov.Size = new System.Drawing.Size(319, 39);
            this.lblPopisKorisnikaNaslov.TabIndex = 5;
            this.lblPopisKorisnikaNaslov.Text = "POPIS KORISNIKA";
            // 
            // FrmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 526);
            this.Controls.Add(this.lblPopisKorisnikaNaslov);
            this.Controls.Add(this.btnPovratakKorisnik);
            this.Controls.Add(this.dgvKorisnici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKorisnici";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.FrmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPovratakKorisnik;
        private System.Windows.Forms.Label lblPopisKorisnikaNaslov;
    }
}