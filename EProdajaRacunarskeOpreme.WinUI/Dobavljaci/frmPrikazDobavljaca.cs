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

namespace EProdajaRacunarskeOpreme.WinUI.Dobavljaci
{
    public partial class frmPrikazDobavljaca : Form
    {
        APIService _service = new APIService("Dobavljaci");
        public frmPrikazDobavljaca()
        {
            InitializeComponent();
            dgv_Dobavljaci.AutoGenerateColumns = false;
        }

        private async void btn_PrikaziDobavljaca_Click(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }

        private async void frmPrikazDobavljaca_Load(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }

        private async Task LoadDataGrid()
        {
            DobavljaciSearchObject searchobject = new DobavljaciSearchObject()
            {
                Naziv = txtPretraga.Text
            };

            var list = await _service.GetAll<List<Prodaja.Model.Dobavljaci>>(searchobject);

            dgv_Dobavljaci.DataSource = list;
        }

        private void dgv_Dobavljaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgv_Dobavljaci.SelectedRows[0].DataBoundItem;


            frmDodajUrediDobavljaca frm = new frmDodajUrediDobavljaca(item as Prodaja.Model.Dobavljaci);
            frm.ShowDialog();
        }

        private void btn_Novi_Click(object sender, EventArgs e)
        {
            frmDodajUrediDobavljaca frm = new frmDodajUrediDobavljaca();
            frm.ShowDialog();
        }
    }
}
