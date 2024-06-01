using MyDoc.Klase;
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
    public partial class FrmKorisnici : Form
    {
        public FrmKorisnici()
        {
            InitializeComponent();
        }

        private void FrmKorisnici_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();

        }

        private void PrikaziKorisnike()
        {
            List<Korisnik> korisnici = RepozitorijKorisnika.IspisKorisnika();
            dgvKorisnici.DataSource = korisnici;
        }

        private void btnPovratakKorisnik_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNaslovna frmNaslovna = new FrmNaslovna();
            frmNaslovna.ShowDialog();
            Close();
        }
    }
}
