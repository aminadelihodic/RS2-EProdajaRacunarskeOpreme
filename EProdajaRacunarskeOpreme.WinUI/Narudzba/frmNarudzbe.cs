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
    public partial class frmNarudzbe : Form
    {
        APIService _service = new APIService("Narudzba");
        public frmNarudzbe()
        {
            InitializeComponent();
            dgv_Narudzba.AutoGenerateColumns = false;
        }

        private async void frmNarudzbe_Load(object sender, EventArgs e)
        {
            await LoadDgv();
        }

        private async void btn_PrikaziNabavku_Click(object sender, EventArgs e)
        {
            await LoadDgv();
        }
        private void Reload(object sender, EventArgs e)
        {
            frmNarudzbe_Load(sender, e);
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

    }
}

