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

namespace EProdajaRacunarskeOpreme.WinUI.Izvještaji
{
    public partial class frmIzvjestaji : Form
    {
        private readonly APIService _proizvodi = new APIService("Proizvodi");
        private readonly APIService _narudzbest = new APIService("NarudzbaStavke");
        private readonly APIService _naruzdbe = new APIService("Narudzba");
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            if (dtpDatumDo.Enabled == true && dtpDatumOd.Enabled == true && txtPretraga.Enabled == true)
            {
                var search = new NarudzbaSearchObject()
                {
                    BrojNarudzbe = txtPretraga.Text
                };

                var listaNarudzbi = await _naruzdbe.GetAll<List<Prodaja.Model.Narudzba>>(search);
                List<IzvjNarudzbe> result = new List<IzvjNarudzbe>();

                foreach (var item in listaNarudzbi)
                {
                    if (dtpDatumOd.Value < item.Datum && item.Datum < dtpDatumDo.Value)
                    {
                        result.Add(new IzvjNarudzbe
                        {
                            BrojNarudzbe = item.BrojNarudzbe,
                            Datum = item.Datum,
                            IznosRacuna = item.IznosRacuna
                        });
                    }
                }
                dgv.DataSource = result;
            }
        }



        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = true;
            dtpDatumOd.Enabled = true;

            txtPretraga.Enabled = true;
            btnPretraga.Enabled = true;

            dgv.DataSource = null;

            txtPretraga.Text = "";
            if (dgv.DataSource == null)
            {
                MessageBox.Show("Izaberite parametre, i pritisnite button Pretrazi!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = dgv.Height;
            dgv.Height = dgv.RowCount * dgv.RowTemplate.Height * 2;
            bmp = new Bitmap(dgv.Width, dgv.Height);
            dgv.DrawToBitmap(bmp, new Rectangle(0, 0, dgv.Width, dgv.Height));
            dgv.Height = height;
            pr_dialog.ShowDialog();
        }

        Bitmap bmp;
        private void pr_doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private async void btnArtikli_Click(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = false;
            dtpDatumOd.Enabled = false;
            txtPretraga.Enabled = false;
            btnPretraga.Enabled = false;

            List<ProdaniProiz> prodani = new List<ProdaniProiz>();

            List<Prodaja.Model.Proizvodi> listaProiz = await _proizvodi.GetAll<List<Prodaja.Model.Proizvodi>>(null);

            List<NarudzbaStavke> listaNarudzbi = await _narudzbest.GetAll<List<NarudzbaStavke>>(null);


            foreach (var proiz in listaProiz)
            {
                var narudzbe = listaNarudzbi.Where(x => x.ProizvodId == proiz.ProizvodId);
                ProdaniProiz proizvodi = new ProdaniProiz
                {

                    Cijena = proiz.Cijena,
                    Naziv = proiz.Naziv,
                    Sifra = proiz.Sifra,
                    Kolicina = narudzbe.Sum(x => x.Kolicina),
                    Ukupno = narudzbe.Sum(x => x.Kolicina * x.Proizvod.Cijena)
                };
                if (proizvodi.Kolicina > 0)
                    prodani.Add(proizvodi);
            }

            dgv.DataSource = prodani;
        }
    }
}
