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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlacanja
            // 
            this.dgvPlacanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacanja.Location = new System.Drawing.Point(12, 58);
            this.dgvPlacanja.Name = "dgvPlacanja";
            this.dgvPlacanja.RowHeadersWidth = 51;
            this.dgvPlacanja.RowTemplate.Height = 24;
            this.dgvPlacanja.Size = new System.Drawing.Size(933, 386);
            this.dgvPlacanja.TabIndex = 0;
            this.dgvPlacanja.SelectionChanged += new System.EventHandler(this.dgvPlacanja_SelectionChanged);
            // 
            // lblNovoPlacanje
            // 
            this.lblNovoPlacanje.AutoSize = true;
            this.lblNovoPlacanje.Location = new System.Drawing.Point(66, 500);
            this.lblNovoPlacanje.Name = "lblNovoPlacanje";
            this.lblNovoPlacanje.Size = new System.Drawing.Size(132, 16);
            this.lblNovoPlacanje.TabIndex = 1;
            this.lblNovoPlacanje.Text = "Dodaj novo plaćanje";
            // 
            // btnDodajPlacanje
            // 
            this.btnDodajPlacanje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDodajPlacanje.Location = new System.Drawing.Point(83, 519);
            this.btnDodajPlacanje.Name = "btnDodajPlacanje";
            this.btnDodajPlacanje.Size = new System.Drawing.Size(86, 44);
            this.btnDodajPlacanje.TabIndex = 2;
            this.btnDodajPlacanje.Text = "DODAJ";
            this.btnDodajPlacanje.UseVisualStyleBackColor = false;
            this.btnDodajPlacanje.Click += new System.EventHandler(this.btnDodajPlacanje_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPovratak.Location = new System.Drawing.Point(12, 8);
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
            this.btnIzbrisi.Location = new System.Drawing.Point(430, 519);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(86, 44);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "IZBRIŠI";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // lblBrisanje
            // 
            this.lblBrisanje.AutoSize = true;
            this.lblBrisanje.Location = new System.Drawing.Point(413, 500);
            this.lblBrisanje.Name = "lblBrisanje";
            this.lblBrisanje.Size = new System.Drawing.Size(133, 16);
            this.lblBrisanje.TabIndex = 4;
            this.lblBrisanje.Text = "Izbriši označen redak";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAzuriraj.Enabled = false;
            this.btnAzuriraj.Location = new System.Drawing.Point(736, 519);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(86, 44);
            this.btnAzuriraj.TabIndex = 7;
            this.btnAzuriraj.Text = "AŽURIRAJ";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click_1);
            // 
            // lblAzuriraj
            // 
            this.lblAzuriraj.AutoSize = true;
            this.lblAzuriraj.Location = new System.Drawing.Point(683, 500);
            this.lblAzuriraj.Name = "lblAzuriraj";
            this.lblAzuriraj.Size = new System.Drawing.Size(219, 16);
            this.lblAzuriraj.TabIndex = 6;
            this.lblAzuriraj.Text = "Ažuriraj podatke iz označenog retka";
            // 
            // lblPretrazivanjeNazivKorisnika
            // 
            this.lblPretrazivanjeNazivKorisnika.AutoSize = true;
            this.lblPretrazivanjeNazivKorisnika.Location = new System.Drawing.Point(151, 22);
            this.lblPretrazivanjeNazivKorisnika.Name = "lblPretrazivanjeNazivKorisnika";
            this.lblPretrazivanjeNazivKorisnika.Size = new System.Drawing.Size(202, 16);
            this.lblPretrazivanjeNazivKorisnika.TabIndex = 8;
            this.lblPretrazivanjeNazivKorisnika.Text = "Pretrazivanje po nazivu korisnika";
            // 
            // txtPretrazivanjeNazivKorisnika
            // 
            this.txtPretrazivanjeNazivKorisnika.Location = new System.Drawing.Point(359, 22);
            this.txtPretrazivanjeNazivKorisnika.Name = "txtPretrazivanjeNazivKorisnika";
            this.txtPretrazivanjeNazivKorisnika.Size = new System.Drawing.Size(201, 22);
            this.txtPretrazivanjeNazivKorisnika.TabIndex = 9;
            this.txtPretrazivanjeNazivKorisnika.TextChanged += new System.EventHandler(this.txtPretrazivanjeNazivKorisnika_TextChanged);
            // 
            // txtPretrazivanjeNazivUsluge
            // 
            this.txtPretrazivanjeNazivUsluge.Location = new System.Drawing.Point(814, 22);
            this.txtPretrazivanjeNazivUsluge.Name = "txtPretrazivanjeNazivUsluge";
            this.txtPretrazivanjeNazivUsluge.Size = new System.Drawing.Size(201, 22);
            this.txtPretrazivanjeNazivUsluge.TabIndex = 11;
            this.txtPretrazivanjeNazivUsluge.TextChanged += new System.EventHandler(this.txtPretrazivanjeNazivUsluge_TextChanged);
            // 
            // lblPretrazivanjeNazivUsluge
            // 
            this.lblPretrazivanjeNazivUsluge.AutoSize = true;
            this.lblPretrazivanjeNazivUsluge.Location = new System.Drawing.Point(620, 22);
            this.lblPretrazivanjeNazivUsluge.Name = "lblPretrazivanjeNazivUsluge";
            this.lblPretrazivanjeNazivUsluge.Size = new System.Drawing.Size(188, 16);
            this.lblPretrazivanjeNazivUsluge.TabIndex = 10;
            this.lblPretrazivanjeNazivUsluge.Text = "Pretrazivanje po nazivu usluge";
            // 
            // FrmPlacanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 740);
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
            this.Name = "FrmPlacanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPlacanja";
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
    }
}