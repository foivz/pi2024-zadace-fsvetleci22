namespace MyDoc
{
    partial class FrmPlacanja
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
            this.dgvPlacanja = new System.Windows.Forms.DataGridView();
            this.lblNovoPlacanje = new System.Windows.Forms.Label();
            this.btnDodajPlacanje = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.lblBrisanje = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.lblAzuriraj = new System.Windows.Forms.Label();
            this.lblPretrazivanjeNazivKorisnika = new System.Windows.Forms.Label();
            this.txtPretrazivanjeNazivKorisnika = new System.Windows.Forms.TextBox();
            this.txtPretrazivanjeNazivUsluge = new System.Windows.Forms.TextBox();
            this.lblPretrazivanjeNazivUsluge = new System.Windows.Forms.Label();
            this.lblNaslovPlacanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlacanja
            // 
            this.dgvPlacanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPlacanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacanja.Location = new System.Drawing.Point(25, 169);
            this.dgvPlacanja.Name = "dgvPlacanja";
            this.dgvPlacanja.RowHeadersWidth = 51;
            this.dgvPlacanja.RowTemplate.Height = 24;
            this.dgvPlacanja.Size = new System.Drawing.Size(1016, 408);
            this.dgvPlacanja.TabIndex = 0;
            this.dgvPlacanja.SelectionChanged += new System.EventHandler(this.dgvPlacanja_SelectionChanged);
            // 
            // lblNovoPlacanje
            // 
            this.lblNovoPlacanje.AutoSize = true;
            this.lblNovoPlacanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNovoPlacanje.Location = new System.Drawing.Point(71, 607);
            this.lblNovoPlacanje.Name = "lblNovoPlacanje";
            this.lblNovoPlacanje.Size = new System.Drawing.Size(160, 20);
            this.lblNovoPlacanje.TabIndex = 1;
            this.lblNovoPlacanje.Text = "Dodaj novo plaćanje";
            // 
            // btnDodajPlacanje
            // 
            this.btnDodajPlacanje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDodajPlacanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajPlacanje.Location = new System.Drawing.Point(86, 645);
            this.btnDodajPlacanje.Name = "btnDodajPlacanje";
            this.btnDodajPlacanje.Size = new System.Drawing.Size(135, 55);
            this.btnDodajPlacanje.TabIndex = 2;
            this.btnDodajPlacanje.Text = "DODAJ";
            this.btnDodajPlacanje.UseVisualStyleBackColor = false;
            this.btnDodajPlacanje.Click += new System.EventHandler(this.btnDodajPlacanje_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPovratak.Location = new System.Drawing.Point(25, 39);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(86, 44);
            this.btnPovratak.TabIndex = 3;
            this.btnPovratak.Text = "VRATI SE";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIzbrisi.Enabled = false;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIzbrisi.Location = new System.Drawing.Point(444, 645);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(130, 55);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "IZBRIŠI";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // lblBrisanje
            // 
            this.lblBrisanje.AutoSize = true;
            this.lblBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBrisanje.Location = new System.Drawing.Point(426, 611);
            this.lblBrisanje.Name = "lblBrisanje";
            this.lblBrisanje.Size = new System.Drawing.Size(168, 20);
            this.lblBrisanje.TabIndex = 4;
            this.lblBrisanje.Text = "Izbriši označen redak";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAzuriraj.Enabled = false;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAzuriraj.Location = new System.Drawing.Point(785, 645);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(133, 55);
            this.btnAzuriraj.TabIndex = 7;
            this.btnAzuriraj.Text = "AŽURIRAJ";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click_1);
            // 
            // lblAzuriraj
            // 
            this.lblAzuriraj.AutoSize = true;
            this.lblAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAzuriraj.Location = new System.Drawing.Point(721, 611);
            this.lblAzuriraj.Name = "lblAzuriraj";
            this.lblAzuriraj.Size = new System.Drawing.Size(276, 20);
            this.lblAzuriraj.TabIndex = 6;
            this.lblAzuriraj.Text = "Ažuriraj podatke iz označenog retka";
            // 
            // lblPretrazivanjeNazivKorisnika
            // 
            this.lblPretrazivanjeNazivKorisnika.AutoSize = true;
            this.lblPretrazivanjeNazivKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPretrazivanjeNazivKorisnika.Location = new System.Drawing.Point(57, 136);
            this.lblPretrazivanjeNazivKorisnika.Name = "lblPretrazivanjeNazivKorisnika";
            this.lblPretrazivanjeNazivKorisnika.Size = new System.Drawing.Size(224, 18);
            this.lblPretrazivanjeNazivKorisnika.TabIndex = 8;
            this.lblPretrazivanjeNazivKorisnika.Text = "Pretraživanje po nazivu korisnika";
            // 
            // txtPretrazivanjeNazivKorisnika
            // 
            this.txtPretrazivanjeNazivKorisnika.Location = new System.Drawing.Point(297, 133);
            this.txtPretrazivanjeNazivKorisnika.Name = "txtPretrazivanjeNazivKorisnika";
            this.txtPretrazivanjeNazivKorisnika.Size = new System.Drawing.Size(225, 22);
            this.txtPretrazivanjeNazivKorisnika.TabIndex = 9;
            this.txtPretrazivanjeNazivKorisnika.TextChanged += new System.EventHandler(this.txtPretrazivanjeNazivKorisnika_TextChanged);
            // 
            // txtPretrazivanjeNazivUsluge
            // 
            this.txtPretrazivanjeNazivUsluge.Location = new System.Drawing.Point(817, 133);
            this.txtPretrazivanjeNazivUsluge.Name = "txtPretrazivanjeNazivUsluge";
            this.txtPretrazivanjeNazivUsluge.Size = new System.Drawing.Size(224, 22);
            this.txtPretrazivanjeNazivUsluge.TabIndex = 11;
            this.txtPretrazivanjeNazivUsluge.TextChanged += new System.EventHandler(this.txtPretrazivanjeNazivUsluge_TextChanged);
            // 
            // lblPretrazivanjeNazivUsluge
            // 
            this.lblPretrazivanjeNazivUsluge.AutoSize = true;
            this.lblPretrazivanjeNazivUsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPretrazivanjeNazivUsluge.Location = new System.Drawing.Point(592, 136);
            this.lblPretrazivanjeNazivUsluge.Name = "lblPretrazivanjeNazivUsluge";
            this.lblPretrazivanjeNazivUsluge.Size = new System.Drawing.Size(207, 18);
            this.lblPretrazivanjeNazivUsluge.TabIndex = 10;
            this.lblPretrazivanjeNazivUsluge.Text = "Pretraživanje po nazivu usluge";
            // 
            // lblNaslovPlacanje
            // 
            this.lblNaslovPlacanje.AutoSize = true;
            this.lblNaslovPlacanje.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNaslovPlacanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNaslovPlacanje.Location = new System.Drawing.Point(391, 39);
            this.lblNaslovPlacanje.Name = "lblNaslovPlacanje";
            this.lblNaslovPlacanje.Size = new System.Drawing.Size(309, 39);
            this.lblNaslovPlacanje.TabIndex = 12;
            this.lblNaslovPlacanje.Text = "POPIS PLAĆANJA";
            // 
            // FrmPlacanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 742);
            this.Controls.Add(this.lblNaslovPlacanje);
            this.Controls.Add(this.txtPretrazivanjeNazivUsluge);
            this.Controls.Add(this.lblPretrazivanjeNazivUsluge);
            this.Controls.Add(this.txtPretrazivanjeNazivKorisnika);
            this.Controls.Add(this.lblPretrazivanjeNazivKorisnika);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lblAzuriraj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.lblBrisanje);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnDodajPlacanje);
            this.Controls.Add(this.lblNovoPlacanje);
            this.Controls.Add(this.dgvPlacanja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlacanja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placanja";
            this.Load += new System.EventHandler(this.FrmPlacanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlacanja;
        private System.Windows.Forms.Label lblNovoPlacanje;
        private System.Windows.Forms.Button btnDodajPlacanje;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label lblBrisanje;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label lblAzuriraj;
        private System.Windows.Forms.Label lblPretrazivanjeNazivKorisnika;
        private System.Windows.Forms.TextBox txtPretrazivanjeNazivKorisnika;
        private System.Windows.Forms.TextBox txtPretrazivanjeNazivUsluge;
        private System.Windows.Forms.Label lblPretrazivanjeNazivUsluge;
        private System.Windows.Forms.Label lblNaslovPlacanje;
    }
}