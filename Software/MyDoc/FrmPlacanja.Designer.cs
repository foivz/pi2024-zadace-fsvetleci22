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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlacanja
            // 
            this.dgvPlacanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacanja.Location = new System.Drawing.Point(90, 90);
            this.dgvPlacanja.Name = "dgvPlacanja";
            this.dgvPlacanja.RowHeadersWidth = 51;
            this.dgvPlacanja.RowTemplate.Height = 24;
            this.dgvPlacanja.Size = new System.Drawing.Size(601, 269);
            this.dgvPlacanja.TabIndex = 0;
            // 
            // FrmPlacanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPlacanja);
            this.Name = "FrmPlacanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPlacanja";
            this.Load += new System.EventHandler(this.FrmPlacanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlacanja;
    }
}