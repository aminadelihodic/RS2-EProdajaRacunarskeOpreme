using Prodaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProdajaRacunarskeOpreme.WinUI.Nabavka
{
    public partial class frmPrikazNabavke : Form
    {
        APIService _service = new APIService("Nabavka");
        public frmPrikazNabavke()
        {
            InitializeComponent();
            dgv_Nabavka.AutoGenerateColumns = false;
        }

        private async void btn_PrikaziNabavku_Click(object sender, EventArgs e)
        {
            await LoadDgv();
        }

        private async void frmPrikazNabavke_Load(object sender, EventArgs e)
        {
            await LoadDgv();
        }
        private void Reload(object sender,EventArgs e)
        {
            frmPrikazNabavke_Load(sender, e);
        }
        private async Task LoadDgv()
        {
            NabavkaSearchObject searchobject = new NabavkaSearchObject()
            {
                BrojNabavke = txtBroj.Text,
                IncludeDobavljac = true,
                IncludeKorisnik = true

            };

            var list = await _service.GetAll<List<Prodaja.Model.Nabavka>>(searchobject);

            dgv_Nabavka.DataSource = list;
        }

        private void btn_Novi_Click(object sender, EventArgs e)
        {
            frmDodajUrediNabavku frm = new frmDodajUrediNabavku();
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }

        private void dgv_Nabavka_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgv_Nabavka.SelectedRows[0].DataBoundItem;


            frmDodajUrediNabavku frm = new frmDodajUrediNabavku(item as Prodaja.Model.Nabavka);
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }
    }
}
