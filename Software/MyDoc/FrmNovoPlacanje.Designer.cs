namespace MyDoc
{
    partial class FrmNovoPlacanje
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
            this.cboNazivKorisnika = new System.Windows.Forms.ComboBox();
            this.lblNazivKorisnika = new System.Windows.Forms.Label();
            this.lblNazivUsluge = new System.Windows.Forms.Label();
            this.cboNazivUsluge = new System.Windows.Forms.ComboBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnPlati = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblNovoPlacanjeNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboNazivKorisnika
            // 
            this.cboNazivKorisnika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNazivKorisnika.FormattingEnabled = true;
            this.cboNazivKorisnika.Items.AddRange(new object[] {
            "Ana Horvat",
            "Ivan Ivic",
            "Marija Maric",
            "Petar Peric",
            "Lucija Lovric",
            "Marko Markic",
            "Josipa Josipovic",
            "Tomislav Tomic",
            "Ivana Ivanic",
            "Nikola Nikolic"});
            this.cboNazivKorisnika.Location = new System.Drawing.Point(112, 112);
            this.cboNazivKorisnika.Name = "cboNazivKorisnika";
            this.cboNazivKorisnika.Size = new System.Drawing.Size(200, 24);
            this.cboNazivKorisnika.TabIndex = 0;
            // 
            // lblNazivKorisnika
            // 
            this.lblNazivKorisnika.AutoSize = true;
            this.lblNazivKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNazivKorisnika.Location = new System.Drawing.Point(154, 89);
            this.lblNazivKorisnika.Name = "lblNazivKorisnika";
            this.lblNazivKorisnika.Size = new System.Drawing.Size(127, 20);
            this.lblNazivKorisnika.TabIndex = 1;
            this.lblNazivKorisnika.Text = "Naziv korisnika:";
            this.lblNazivKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNazivUsluge
            // 
            this.lblNazivUsluge.AutoSize = true;
            this.lblNazivUsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNazivUsluge.Location = new System.Drawing.Point(165, 182);
            this.lblNazivUsluge.Name = "lblNazivUsluge";
            this.lblNazivUsluge.Size = new System.Drawing.Size(105, 20);
            this.lblNazivUsluge.TabIndex = 3;
            this.lblNazivUsluge.Text = "Naziv usluge";
            // 
            // cboNazivUsluge
            // 
            this.cboNazivUsluge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNazivUsluge.FormattingEnabled = true;
            this.cboNazivUsluge.Items.AddRange(new object[] {
            "Health Basic",
            "Health Advanced",
            "Health Premium",
            "Konzultacije sa lijecnikom opce prakse",
            "Usluga mobilnog vadenja krvi",
            "Izlazak na lokaciju korisnika"});
            this.cboNazivUsluge.Location = new System.Drawing.Point(112, 205);
            this.cboNazivUsluge.Name = "cboNazivUsluge";
            this.cboNazivUsluge.Size = new System.Drawing.Size(200, 24);
            this.cboNazivUsluge.TabIndex = 2;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCijena.Location = new System.Drawing.Point(180, 271);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(82, 20);
            this.lblCijena.TabIndex = 4;
            this.lblCijena.Text = "Cijena (€)";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(112, 294);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(200, 22);
            this.txtCijena.TabIndex = 5;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(112, 382);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 6;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDatum.Location = new System.Drawing.Point(180, 359);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(59, 20);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Datum";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(112, 473);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 88);
            this.txtOpis.TabIndex = 9;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOpis.Location = new System.Drawing.Point(159, 450);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(111, 20);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Opis plaćanja";
            // 
            // btnPlati
            // 
            this.btnPlati.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPlati.Location = new System.Drawing.Point(226, 611);
            this.btnPlati.Name = "btnPlati";
            this.btnPlati.Size = new System.Drawing.Size(118, 49);
            this.btnPlati.TabIndex = 10;
            this.btnPlati.Text = "POHRANI";
            this.btnPlati.UseVisualStyleBackColor = false;
            this.btnPlati.Click += new System.EventHandler(this.btnPlati_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOdustani.Location = new System.Drawing.Point(69, 611);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(112, 49);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblNovoPlacanjeNaslov
            // 
            this.lblNovoPlacanjeNaslov.AutoSize = true;
            this.lblNovoPlacanjeNaslov.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNovoPlacanjeNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNovoPlacanjeNaslov.Location = new System.Drawing.Point(56, 22);
            this.lblNovoPlacanjeNaslov.Name = "lblNovoPlacanjeNaslov";
            this.lblNovoPlacanjeNaslov.Size = new System.Drawing.Size(316, 29);
            this.lblNovoPlacanjeNaslov.TabIndex = 12;
            this.lblNovoPlacanjeNaslov.Text = "DODAJ NOVO PLAĆANJE";
            // 
            // FrmNovoPlacanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 693);
            this.Controls.Add(this.lblNovoPlacanjeNaslov);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPlati);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblNazivUsluge);
            this.Controls.Add(this.cboNazivUsluge);
            this.Controls.Add(this.lblNazivKorisnika);
            this.Controls.Add(this.cboNazivKorisnika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoPlacanje";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Plaćanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNazivKorisnika;
        private System.Windows.Forms.Label lblNazivKorisnika;
        private System.Windows.Forms.Label lblNazivUsluge;
        private System.Windows.Forms.ComboBox cboNazivUsluge;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnPlati;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNovoPlacanjeNaslov;
    }
}