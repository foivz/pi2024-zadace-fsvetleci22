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
            this.cboNazivKorisnika.Location = new System.Drawing.Point(134, 83);
            this.cboNazivKorisnika.Name = "cboNazivKorisnika";
            this.cboNazivKorisnika.Size = new System.Drawing.Size(152, 24);
            this.cboNazivKorisnika.TabIndex = 0;
            // 
            // lblNazivKorisnika
            // 
            this.lblNazivKorisnika.AutoSize = true;
            this.lblNazivKorisnika.Location = new System.Drawing.Point(154, 64);
            this.lblNazivKorisnika.Name = "lblNazivKorisnika";
            this.lblNazivKorisnika.Size = new System.Drawing.Size(101, 16);
            this.lblNazivKorisnika.TabIndex = 1;
            this.lblNazivKorisnika.Text = "Naziv korisnika:";
            this.lblNazivKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNazivUsluge
            // 
            this.lblNazivUsluge.AutoSize = true;
            this.lblNazivUsluge.Location = new System.Drawing.Point(171, 154);
            this.lblNazivUsluge.Name = "lblNazivUsluge";
            this.lblNazivUsluge.Size = new System.Drawing.Size(84, 16);
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
            this.cboNazivUsluge.Location = new System.Drawing.Point(134, 173);
            this.cboNazivUsluge.Name = "cboNazivUsluge";
            this.cboNazivUsluge.Size = new System.Drawing.Size(152, 24);
            this.cboNazivUsluge.TabIndex = 2;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(177, 239);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(45, 16);
            this.lblCijena.TabIndex = 4;
            this.lblCijena.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(134, 258);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(152, 22);
            this.txtCijena.TabIndex = 5;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(135, 340);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(151, 22);
            this.dtpDatum.TabIndex = 6;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(177, 321);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(46, 16);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Datum";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(112, 412);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 88);
            this.txtOpis.TabIndex = 9;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(165, 393);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(90, 16);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Opis plaćanja";
            // 
            // btnPlati
            // 
            this.btnPlati.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlati.Location = new System.Drawing.Point(221, 515);
            this.btnPlati.Name = "btnPlati";
            this.btnPlati.Size = new System.Drawing.Size(102, 53);
            this.btnPlati.TabIndex = 10;
            this.btnPlati.Text = "POHRANI";
            this.btnPlati.UseVisualStyleBackColor = false;
            this.btnPlati.Click += new System.EventHandler(this.btnPlati_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOdustani.Location = new System.Drawing.Point(103, 515);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 53);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmNovoPlacanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 580);
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
            this.Name = "FrmNovoPlacanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNovoPlacanje";
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
    }
}