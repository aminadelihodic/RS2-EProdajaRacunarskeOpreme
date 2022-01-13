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

namespace EProdajaRacunarskeOpreme.WinUI.Proizvodi
{
    public partial class frmPrikazProizvoda : Form
    {
        APIService _service = new APIService("Proizvodi");
        
        public frmPrikazProizvoda()
        {
            InitializeComponent();
            dgv_Proizvodi.AutoGenerateColumns = false;
        }

        private async void btn_PrikaziProizvod_Click(object sender, EventArgs e)
        {
            await LoadDgv();
        }
        private void Reload(object sender,EventArgs e)
        {
            frmPrikazProizvoda_Load(sender, e);
        }
        private async Task LoadDgv()
        {
            ProizvodiSearchObject searchobject = new ProizvodiSearchObject()
            {
                Naziv = txtNaziv.Text,
                IncludeVrstaProizvoda = true,
                IncludeProizvodjac = true,
            };

            var list = await _service.GetAll<List<Prodaja.Model.Proizvodi>>(searchobject);

            dgv_Proizvodi.DataSource = list;
        }

        private async void frmPrikazProizvoda_Load(object sender, EventArgs e)
        {
            await LoadDgv();
        }
        
        private void btn_Novi_Click(object sender, EventArgs e)
        {
            frmDodajUrediProizvod frm = new frmDodajUrediProizvod();
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }

        private void dgv_Proizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgv_Proizvodi.SelectedRows[0].DataBoundItem;

            //
            frmDodajUrediProizvod frm = new frmDodajUrediProizvod(item as Prodaja.Model.Proizvodi);
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }
    }
}
