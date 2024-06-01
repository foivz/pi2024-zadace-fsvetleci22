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
    public partial class FrmPlacanja : Form
    {
        public FrmPlacanja()
        {
            InitializeComponent();
        }

        private void FrmPlacanja_Load(object sender, EventArgs e)
        {
            PrikaziKorisnike();
        }

        private void PrikaziKorisnike()
        {
            List<Placanje> placanja = RepozitorijPlacanja.IspisPlacanja();
            dgvPlacanja.DataSource = placanja;
        }

        private void btnDodajPlacanje_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNovoPlacanje frmNovoPlacanje = new FrmNovoPlacanje();
            frmNovoPlacanje.ShowDialog();
            Close();
        }



        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNaslovna frmNaslovna = new FrmNaslovna();
            frmNaslovna.ShowDialog();
            Close();
        }

        private void dgvPlacanja_SelectionChanged(object sender, EventArgs e)
        {
            btnIzbrisi.Enabled = true;
            btnAzuriraj.Enabled = true;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {

            Placanje placanje = dgvPlacanja.CurrentRow.DataBoundItem as Placanje;
            DialogResult dijalog = MessageBox.Show("Jeste li sigurni da želite obrisati ovaj redak?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dijalog != DialogResult.No)
            {
                RepozitorijPlacanja.IzbrisiIzBaze(placanje);
                PrikaziKorisnike();
            }
            

        }

        

        private void btnAzuriraj_Click_1(object sender, EventArgs e)
        {
            Hide();
            Placanje placanje = dgvPlacanja.CurrentRow.DataBoundItem as Placanje;
            FrmAzuriraj frmAzuriraj = new FrmAzuriraj(placanje);
            frmAzuriraj.ShowDialog();
            Close();

        }
    }
}
