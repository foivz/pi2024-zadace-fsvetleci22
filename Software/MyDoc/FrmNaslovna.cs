using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDoc
{
    public partial class FrmNaslovna : Form
    {
        public FrmNaslovna()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNaslovna_Load(object sender, EventArgs e)
        {

        }

        private void FrmNaslovna_Click(object sender, EventArgs e)
        {

        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            Hide();
            FrmKorisnici frmKorisnici = new FrmKorisnici();
            frmKorisnici.ShowDialog();
            Close();
        }

        private void btnIzvjestaj1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPlacanja frmPlacanja = new FrmPlacanja();
            frmPlacanja.ShowDialog();
            Close();
        }
    }
}
