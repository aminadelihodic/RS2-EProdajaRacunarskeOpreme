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
    public partial class frmNabavka2 : Form
    {
        APIService _service = new APIService("Nabavka");
        public frmNabavka2()
        {
            InitializeComponent();
            dgv_Nabavka.AutoGenerateColumns = false;
        }

        private async void frmNabavka2_Load(object sender, EventArgs e)
        {
            await LoadDgv();
        }
        private void Reload(object sender, EventArgs e)
        {
            frmNabavka2_Load(sender, e);
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
            frmNovaNabavka frm = new frmNovaNabavka();
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }

        private async void btn_PrikaziNabavku_Click(object sender, EventArgs e)
        {
            await LoadDgv();
        }
    }
}

