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
    public partial class FrmNovoPlacanje : Form
    {
        private Placanje placanje;

        public FrmNovoPlacanje()
        {
            InitializeComponent();
        }

        

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPlacanja frmPlacanja = new FrmPlacanja();
            frmPlacanja.ShowDialog();
            Close();
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            var placanje = new Placanje
            {
                nazivKorisnika = cboNazivKorisnika.SelectedItem.ToString(),
                nazivUsluge = cboNazivUsluge.SelectedItem.ToString(),
                cijena = float.Parse(txtCijena.Text),
                datumPlacanja = dtpDatum.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                opisPlacanja = txtOpis.Text.ToString()
            };

            RepozitorijPlacanja.DodajUBazu(placanje);
            Hide();
            FrmPlacanja frmPlacanja = new FrmPlacanja();
            frmPlacanja.ShowDialog();
            Close();
            

        }
    }
}
