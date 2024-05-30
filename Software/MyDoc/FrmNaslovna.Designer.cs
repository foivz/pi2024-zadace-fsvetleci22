namespace MyDoc
{
    partial class FrmNaslovna
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.lblIzvještaj = new System.Windows.Forms.Label();
            this.lblPlaćanja = new System.Windows.Forms.Label();
            this.btnIzvjestaj1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(229, 148);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(343, 36);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "DOBRO DOŠLI ADMINE";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNaslov.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzvjestaj.Location = new System.Drawing.Point(201, 275);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(113, 45);
            this.btnIzvjestaj.TabIndex = 1;
            this.btnIzvjestaj.Text = "GENERIRAJ";
            this.btnIzvjestaj.UseVisualStyleBackColor = false;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // lblIzvještaj
            // 
            this.lblIzvještaj.AutoSize = true;
            this.lblIzvještaj.Location = new System.Drawing.Point(175, 256);
            this.lblIzvještaj.Name = "lblIzvještaj";
            this.lblIzvještaj.Size = new System.Drawing.Size(175, 16);
            this.lblIzvještaj.TabIndex = 2;
            this.lblIzvještaj.Text = "Izvještaj sa svim korisnicima";
            // 
            // lblPlaćanja
            // 
            this.lblPlaćanja.AutoSize = true;
            this.lblPlaćanja.Location = new System.Drawing.Point(459, 256);
            this.lblPlaćanja.Name = "lblPlaćanja";
            this.lblPlaćanja.Size = new System.Drawing.Size(173, 16);
            this.lblPlaćanja.TabIndex = 4;
            this.lblPlaćanja.Text = "Izvještaj sa svim plaćanjima";
            // 
            // btnIzvjestaj1
            // 
            this.btnIzvjestaj1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzvjestaj1.Location = new System.Drawing.Point(485, 275);
            this.btnIzvjestaj1.Name = "btnIzvjestaj1";
            this.btnIzvjestaj1.Size = new System.Drawing.Size(113, 45);
            this.btnIzvjestaj1.TabIndex = 3;
            this.btnIzvjestaj1.Text = "GENERIRAJ";
            this.btnIzvjestaj1.UseVisualStyleBackColor = false;
            this.btnIzvjestaj1.Click += new System.EventHandler(this.btnIzvjestaj1_Click);
            // 
            // FrmNaslovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 545);
            this.Controls.Add(this.lblPlaćanja);
            this.Controls.Add(this.btnIzvjestaj1);
            this.Controls.Add(this.lblIzvještaj);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNaslovna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyDoc";
            this.Load += new System.EventHandler(this.FrmNaslovna_Load);
            this.Click += new System.EventHandler(this.FrmNaslovna_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.Label lblIzvještaj;
        private System.Windows.Forms.Label lblPlaćanja;
        private System.Windows.Forms.Button btnIzvjestaj1;
    }
}

