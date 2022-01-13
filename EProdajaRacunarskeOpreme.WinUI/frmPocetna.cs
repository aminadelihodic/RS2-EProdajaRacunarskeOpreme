using EProdajaRacunarskeOpreme.WinUI.Dobavljaci;
using EProdajaRacunarskeOpreme.WinUI.Izvještaji;
using EProdajaRacunarskeOpreme.WinUI.Klijenti;
using EProdajaRacunarskeOpreme.WinUI.Korisnici;
using EProdajaRacunarskeOpreme.WinUI.Nabavka;
using EProdajaRacunarskeOpreme.WinUI.Narudzba;
using EProdajaRacunarskeOpreme.WinUI.Proizvodi;
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
    public partial class frmPocetna : Form
    {
        private int childFormNumber = 0;

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void prikazKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazKorisnika korisnici = new frmPrikazKorisnika();
            korisnici.MdiParent = this;
            korisnici.Show();
        }

        private void prikazProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazProizvoda proizvodi = new frmPrikazProizvoda();
            proizvodi.MdiParent = this;
            proizvodi.Show();
        }

        private void prikazDobavljacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazDobavljaca proizvodi = new frmPrikazDobavljaca();
            proizvodi.MdiParent = this;
            proizvodi.Show();
        }

        private void prikazNabavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazNabavke nabavke = new frmPrikazNabavke();
            nabavke.MdiParent = this;
            nabavke.Show();
        }

        private void prikazNarudzbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazNarudzbe nabavke = new frmPrikazNarudzbe();
            nabavke.MdiParent = this;
            nabavke.Show();
        }

        private void prikazKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazKlijenata klijenti = new frmPrikazKlijenata();
            klijenti.MdiParent = this;
            klijenti.Show();
        }

        private void prikazIzvještajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestaji klijenti = new frmIzvjestaji();
            klijenti.MdiParent = this;
            klijenti.Show();
        }

    }
}
