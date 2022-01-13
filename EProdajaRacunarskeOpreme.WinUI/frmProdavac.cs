using EProdajaRacunarskeOpreme.WinUI.Nabavka;
using EProdajaRacunarskeOpreme.WinUI.Narudzba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProdajaRacunarskeOpreme.WinUI
{
    public partial class frmProdavac : Form
    {
        public frmProdavac()
        {
            InitializeComponent();
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            frmNarudzbe frm = new frmNarudzbe();
            frm.Show();
        }

        private void btnNabavke_Click(object sender, EventArgs e)
        {
            frmNabavka2 frm = new frmNabavka2();
            frm.Show();
        }
    }
}
