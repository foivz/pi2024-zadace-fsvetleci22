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
    }
}
