using EProdajaRacunarskeOpreme.WinUI.Helper;
using Prodaja.Model;
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

namespace EProdajaRacunarskeOpreme.WinUI.Narudzba
{
    public partial class frmDodajUrediNarudzbu : Form
    {
        APIService _service = new APIService("Narudzba");
        APIService _Klijentiservice = new APIService("Klijenti");
        APIService _proizvodiService = new APIService("Proizvodi");
        private readonly APIService _serviceStavke = new APIService("NarudzbaStavke");
        private Prodaja.Model.Narudzba _narudzba;

        public frmDodajUrediNarudzbu(Prodaja.Model.Narudzba narudzba = null)
        {
            InitializeComponent();
            _narudzba = narudzba;
            dgvStavke.AutoGenerateColumns = false;
        }

        private async void frmDodajUrediNarudzbu_Load(object sender, EventArgs e)
        {
            await LoadKlijent();
            if (_narudzba != null)
            {
                txtBrojNabavke.Text = _narudzba.BrojNarudzbe;
                dtp_Datum.Value = _narudzba.Datum;
                txtCijena.Text = _narudzba.IznosRacuna.ToString();
                cmbKlijent.SelectedIndex = _narudzba.KlijentId;
                ck_Status.Checked = _narudzba.Status;
                ck_Otkazano.Checked = _narudzba.Otkazano;

                var stavke = await _serviceStavke.GetAll<List<Prodaja.Model.NarudzbaStavke>>(new NarudzbaStavkeSearchRequest
                {
                    NarudzbaId = _narudzba.NarudzbaId
                });
                dgvStavke.DataSource = stavke;
            }
            else
            {
                cmbProizvod.DataSource = await _proizvodiService.GetAll<List<Prodaja.Model.Proizvodi>>(null);
            }

        }

        private async Task LoadKlijent()
        {
            var result = await _Klijentiservice.GetAll<List<Prodaja.Model.Klijenti>>(null);
            cmbKlijent.DataSource = result;
            result.Insert(0, new Prodaja.Model.Klijenti());
            cmbKlijent.ValueMember = "KlijentId";
            cmbKlijent.DisplayMember = "Ime";
        }


        NarudzbaInsertRequest insert = new NarudzbaInsertRequest();
        NarudzbaUpdateRequest update = new NarudzbaUpdateRequest();
        private async void btn_Nabavka_Click(object sender, EventArgs e)
        {


            //insert
            if (ValidirajUnos())
            {
                insert.BrojNarudzbe = update.BrojNarudzbe = txtBrojNabavke.Text;
                insert.Datum = update.Datum = dtp_Datum.Value;
                if (decimal.TryParse(txtCijena.Text, out decimal IznosRacuna))
                {
                    insert.IznosRacuna = update.IznosRacuna = IznosRacuna;
                }
                else if (_narudzba != null)
                {
                    update.IznosRacuna = _narudzba.IznosRacuna;
                }
                var Klijentobj = cmbKlijent.SelectedValue;
                if (int.TryParse(Klijentobj.ToString(), out int KlijentId))
                {
                    insert.KlijentId = update.KlijentId = KlijentId;

                }
                insert.Otkazano = update.Otkazano = ck_Otkazano.Checked;
                insert.Status = update.Status = ck_Status.Checked;

                if (_narudzba == null)
                {
                    insert.stavke = new List<NarudzbaStavkeInsertRequest>();
                    if (dgvStavke.DataSource is List<NarudzbaStavke> ds)
                    {

                        foreach (var item in ds)
                        {
                            insert.stavke.Add(new NarudzbaStavkeInsertRequest
                            {
                                Cijena = item.Cijena,
                                ProizvodId = item.ProizvodId,
                                Kolicina = item.Kolicina
                            });
                        }
                    }

                    await _service.Insert<Prodaja.Model.Narudzba>(insert);
                    MessageBox.Show("Narudzba zakljucena");
                    this.Close();
                }
                else
                {
                    await _service.Update<Prodaja.Model.Narudzba>(_narudzba.NarudzbaId, update);
                    MessageBox.Show("Narudzba izmjenjena");
                    this.Close();
                }
            }
        }
        private bool ValidirajUnos()
        {
            return
                Validator.ValidirajKontrolu(cmbKlijent, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtBrojNabavke, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(dtp_Datum, err, "Obavezna vrijednost");
            ;
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            if (cmbProizvod.SelectedItem is null)
            {
                MessageBox.Show("Odaberite proizvod");
                return;
            }

            if (!int.TryParse(txtKolicina.Text, out int Kolicina) || Kolicina < 1)
            {
                MessageBox.Show("Unesite količinu");
                return;
            }

            var proizvod = cmbProizvod.SelectedItem as Prodaja.Model.Proizvodi;

            var list = new List<NarudzbaStavke>();

            var oldItems = dgvStavke.DataSource as List<NarudzbaStavke>;
            if (oldItems != null)
            {
                foreach (var item in oldItems)
                {
                    list.Add(new NarudzbaStavke
                    {
                        Cijena = item.Cijena,
                        Proizvod = item.Proizvod,
                        ProizvodId = item.ProizvodId,
                        Kolicina = item.Kolicina
                    }); ;
                }
            }

            list.Add(new NarudzbaStavke
            {
                Proizvod = proizvod,
                ProizvodId = proizvod.ProizvodId,
                Cijena = proizvod.Cijena,
                Kolicina = Kolicina
            });

            dgvStavke.DataSource = list;
            txtCijena.Text = list.Sum(x => x.UkupnaCijena).ToString("0.00");
        }
    }
}

