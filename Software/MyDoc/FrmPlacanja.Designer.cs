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
            // 
            // lblNovoPlacanje
            // 
            this.lblNovoPlacanje.AutoSize = true;
            this.lblNovoPlacanje.Location = new System.Drawing.Point(68, 467);
            this.lblNovoPlacanje.Name = "lblNovoPlacanje";
            this.lblNovoPlacanje.Size = new System.Drawing.Size(132, 16);
            this.lblNovoPlacanje.TabIndex = 1;
            this.lblNovoPlacanje.Text = "Dodaj novo plaćanje";
            // 
            // btnDodajPlacanje
            // 
            this.btnDodajPlacanje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDodajPlacanje.Location = new System.Drawing.Point(85, 486);
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
            // FrmPlacanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 543);
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
    }
}