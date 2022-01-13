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

namespace EProdajaRacunarskeOpreme.WinUI.Narudzba
{
    public partial class frmPrikazNarudzbe : Form
    {
        APIService _service = new APIService("Narudzba");
        public frmPrikazNarudzbe()
        {
            InitializeComponent();
            dgv_Narudzba.AutoGenerateColumns = false;
        }

        private async void frmPrikazNarudzbe_Load(object sender, EventArgs e)
        {
            await LoadDgv();
        }
        private void Reload(object sender,EventArgs e)
        {
            frmPrikazNarudzbe_Load(sender, e);
        }
        private async void btn_PrikaziNabavku_Click(object sender, EventArgs e)
        {
            await LoadDgv();
        }

        private async Task LoadDgv()
        {
            NarudzbaSearchObject searchobject = new NarudzbaSearchObject()
            {
                BrojNarudzbe = txtBroj.Text,
                IncludeKlijenti = true

            };
            var list = await _service.GetAll<List<Prodaja.Model.Narudzba>>(searchobject);

            dgv_Narudzba.DataSource = list;
        }

        private void dgv_Narudzba_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgv_Narudzba.SelectedRows[0].DataBoundItem;


            frmDodajUrediNarudzbu frm = new frmDodajUrediNarudzbu(item as Prodaja.Model.Narudzba);
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }

        private void btn_Novi_Click(object sender, EventArgs e)
        {
            frmDodajUrediNarudzbu frm = new frmDodajUrediNarudzbu();
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }
    }
}
