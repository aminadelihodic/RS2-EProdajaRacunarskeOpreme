using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProdajaRacunarskeOpreme.WinUI.Korisnici
{
    public partial class frmPrikazKorisnika : Form
    {
        APIService _service = new APIService("Korisnici");
        public frmPrikazKorisnika()
        {
            InitializeComponent();
            dgv_Korisnici.AutoGenerateColumns = false;
        }

        private async void btn_PrikaziKorisnika_Click(object sender, EventArgs e)
        {
            await LoadDataGrid();

        }
        private void Reload(object sender,EventArgs e)
        {
            frmPrikazKorisnika_Load(sender, e);
        }
        private async Task LoadDataGrid()
        {
            KorisniciSearchObject searchobject = new KorisniciSearchObject()
            {
                Ime = txtIme.Text,
                IncludeKorisnickeUloge = true
            };

            var list = await _service.GetAll<List<Prodaja.Model.Korisnici>>(searchobject);

            dgv_Korisnici.DataSource = list;
        }

        private async void frmPrikazKorisnika_Load(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }

        private void dgv_Korisnici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgv_Korisnici.SelectedRows[0].DataBoundItem;

            
            frmDodajUrediKorisnika frm = new frmDodajUrediKorisnika(item as Prodaja.Model.Korisnici);
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }

        private void btn_Novi_Click(object sender, EventArgs e)
        {
            frmDodajUrediKorisnika frm = new frmDodajUrediKorisnika();
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }

    }
}
