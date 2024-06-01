namespace MyDoc
{
    partial class FrmAzuriraj
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
            this.btnOdustani1 = new System.Windows.Forms.Button();
            this.btnPlati1 = new System.Windows.Forms.Button();
            this.txtOpis1 = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum1 = new System.Windows.Forms.DateTimePicker();
            this.txtCijena1 = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblNazivUsluge = new System.Windows.Forms.Label();
            this.cboNazivUsluge1 = new System.Windows.Forms.ComboBox();
            this.lblNazivKorisnika = new System.Windows.Forms.Label();
            this.cboNazivKorisnika1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOdustani1
            // 
            this.btnOdustani1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOdustani1.Location = new System.Drawing.Point(88, 475);
            this.btnOdustani1.Name = "btnOdustani1";
            this.btnOdustani1.Size = new System.Drawing.Size(102, 53);
            this.btnOdustani1.TabIndex = 23;
            this.btnOdustani1.Text = "ODUSTANI";
            this.btnOdustani1.UseVisualStyleBackColor = false;
            this.btnOdustani1.Click += new System.EventHandler(this.btnOdustani1_Click);
            // 
            // btnPlati1
            // 
            this.btnPlati1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlati1.Location = new System.Drawing.Point(206, 475);
            this.btnPlati1.Name = "btnPlati1";
            this.btnPlati1.Size = new System.Drawing.Size(102, 53);
            this.btnPlati1.TabIndex = 22;
            this.btnPlati1.Text = "POHRANI";
            this.btnPlati1.UseVisualStyleBackColor = false;
            this.btnPlati1.Click += new System.EventHandler(this.btnPlati1_Click);
            // 
            // txtOpis1
            // 
            this.txtOpis1.Location = new System.Drawing.Point(97, 372);
            this.txtOpis1.Multiline = true;
            this.txtOpis1.Name = "txtOpis1";
            this.txtOpis1.Size = new System.Drawing.Size(200, 88);
            this.txtOpis1.TabIndex = 21;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(150, 353);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(90, 16);
            this.lblOpis.TabIndex = 20;
            this.lblOpis.Text = "Opis plaćanja";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(162, 281);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(46, 16);
            this.lblDatum.TabIndex = 19;
            this.lblDatum.Text = "Datum";
            // 
            // dtpDatum1
            // 
            this.dtpDatum1.Location = new System.Drawing.Point(120, 300);
            this.dtpDatum1.Name = "dtpDatum1";
            this.dtpDatum1.Size = new System.Drawing.Size(151, 22);
            this.dtpDatum1.TabIndex = 18;
            // 
            // txtCijena1
            // 
            this.txtCijena1.Location = new System.Drawing.Point(119, 218);
            this.txtCijena1.Name = "txtCijena1";
            this.txtCijena1.Size = new System.Drawing.Size(152, 22);
            this.txtCijena1.TabIndex = 17;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(162, 199);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(45, 16);
            this.lblCijena.TabIndex = 16;
            this.lblCijena.Text = "Cijena";
            // 
            // lblNazivUsluge
            // 
            this.lblNazivUsluge.AutoSize = true;
            this.lblNazivUsluge.Location = new System.Drawing.Point(156, 114);
            this.lblNazivUsluge.Name = "lblNazivUsluge";
            this.lblNazivUsluge.Size = new System.Drawing.Size(84, 16);
            this.lblNazivUsluge.TabIndex = 15;
            this.lblNazivUsluge.Text = "Naziv usluge";
            // 
            // cboNazivUsluge1
            // 
            this.cboNazivUsluge1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNazivUsluge1.FormattingEnabled = true;
            this.cboNazivUsluge1.Items.AddRange(new object[] {
            "Health Basic",
            "Health Advanced",
            "Health Premium",
            "Konzultacije sa lijecnikom opce prakse",
            "Usluga mobilnog vadenja krvi",
            "Izlazak na lokaciju korisnika"});
            this.cboNazivUsluge1.Location = new System.Drawing.Point(119, 133);
            this.cboNazivUsluge1.Name = "cboNazivUsluge1";
            this.cboNazivUsluge1.Size = new System.Drawing.Size(152, 24);
            this.cboNazivUsluge1.TabIndex = 14;
            // 
            // lblNazivKorisnika
            // 
            this.lblNazivKorisnika.AutoSize = true;
            this.lblNazivKorisnika.Location = new System.Drawing.Point(139, 24);
            this.lblNazivKorisnika.Name = "lblNazivKorisnika";
            this.lblNazivKorisnika.Size = new System.Drawing.Size(101, 16);
            this.lblNazivKorisnika.TabIndex = 13;
            this.lblNazivKorisnika.Text = "Naziv korisnika:";
            this.lblNazivKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboNazivKorisnika1
            // 
            this.cboNazivKorisnika1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNazivKorisnika1.FormattingEnabled = true;
            this.cboNazivKorisnika1.Items.AddRange(new object[] {
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
            this.cboNazivKorisnika1.Location = new System.Drawing.Point(119, 43);
            this.cboNazivKorisnika1.Name = "cboNazivKorisnika1";
            this.cboNazivKorisnika1.Size = new System.Drawing.Size(152, 24);
            this.cboNazivKorisnika1.TabIndex = 12;
            // 
            // FrmAzuriraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 556);
            this.Controls.Add(this.btnOdustani1);
            this.Controls.Add(this.btnPlati1);
            this.Controls.Add(this.txtOpis1);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dtpDatum1);
            this.Controls.Add(this.txtCijena1);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblNazivUsluge);
            this.Controls.Add(this.cboNazivUsluge1);
            this.Controls.Add(this.lblNazivKorisnika);
            this.Controls.Add(this.cboNazivKorisnika1);
            this.Name = "FrmAzuriraj";
            this.Text = "FrmAzuriraj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani1;
        private System.Windows.Forms.Button btnPlati1;
        private System.Windows.Forms.TextBox txtOpis1;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum1;
        private System.Windows.Forms.TextBox txtCijena1;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblNazivUsluge;
        private System.Windows.Forms.ComboBox cboNazivUsluge1;
        private System.Windows.Forms.Label lblNazivKorisnika;
        private System.Windows.Forms.ComboBox cboNazivKorisnika1;
    }
}