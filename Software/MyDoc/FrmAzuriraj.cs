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
    public partial class FrmAzuriraj : Form
    {
        private Placanje placanje;

        public FrmAzuriraj()
        {
            InitializeComponent();
        }

        public FrmAzuriraj(Placanje placanje)
        {
            InitializeComponent();
            this.placanje = placanje;
            cboNazivKorisnika1.SelectedItem = placanje.nazivKorisnika;
            cboNazivUsluge1.SelectedItem = placanje.nazivUsluge;
            txtCijena1.Text = placanje.cijena.ToString();
            dtpDatum1.Value = DateTime.Parse(placanje.datumPlacanja.ToString());
            txtOpis1.Text = placanje.opisPlacanja.ToString();
        }

        private void btnOdustani1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPlacanja frmPlacanja = new FrmPlacanja();
            frmPlacanja.ShowDialog();
            Close();
        }

        private void btnPlati1_Click(object sender, EventArgs e)
        {
            var placanje = new Placanje
            {
                idPlacanja = this.placanje.idPlacanja,
                nazivKorisnika = cboNazivKorisnika1.SelectedItem.ToString(),
                nazivUsluge = cboNazivUsluge1.SelectedItem.ToString(),
                cijena = float.Parse(txtCijena1.Text),
                datumPlacanja = dtpDatum1.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                opisPlacanja = txtOpis1.Text.ToString()
            };

            RepozitorijPlacanja.AzurirajPodatkeUBazi(placanje);
            Hide();
            FrmPlacanja frmPlacanja = new FrmPlacanja();
            frmPlacanja.ShowDialog();
            Close();
        }
    }
}
