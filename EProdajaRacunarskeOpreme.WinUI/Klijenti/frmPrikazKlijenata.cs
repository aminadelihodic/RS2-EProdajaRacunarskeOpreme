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

namespace EProdajaRacunarskeOpreme.WinUI.Klijenti
{
    public partial class frmPrikazKlijenata : Form
    {
        APIService _service = new APIService("Klijenti");
        public frmPrikazKlijenata()
        {
            InitializeComponent();
            dgv_Korisnici.AutoGenerateColumns = false;
        }

        private async void btn_PrikaziKorisnika_Click(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }

        private async void frmPrikazKlijenata_Load(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }
        private void Reload(object sender,EventArgs e)
        {
            frmPrikazKlijenata_Load(sender, e);
        }

        private void dgv_Korisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgv_Korisnici.SelectedRows[0].DataBoundItem;


            frmDodajIzmjeniKlijenta frm = new frmDodajIzmjeniKlijenta(item as Prodaja.Model.Klijenti);
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }

        private void btn_Novi_Click(object sender, EventArgs e)
        {
            frmDodajIzmjeniKlijenta frm = new frmDodajIzmjeniKlijenta();
            frm.ShowDialog();
            Reload(this, EventArgs.Empty);
        }

        private async Task LoadDataGrid()
        {
            KlijentiSearchObject searchobject = new KlijentiSearchObject()
            {
                Ime = txtIme.Text
            };

            var list = await _service.GetAll<List<Prodaja.Model.Klijenti>>(searchobject);

            dgv_Korisnici.DataSource = list;
        }

    }
}
