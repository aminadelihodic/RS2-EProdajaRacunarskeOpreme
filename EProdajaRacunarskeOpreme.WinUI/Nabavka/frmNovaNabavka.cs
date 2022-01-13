using EProdajaRacunarskeOpreme.WinUI.Helper;
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

namespace EProdajaRacunarskeOpreme.WinUI.Nabavka
{
    public partial class frmNovaNabavka : Form
    {
        APIService _service = new APIService("Nabavka");
        APIService _serviceKorisnici = new APIService("Korisnici");
        APIService _serviceDob = new APIService("Dobavljaci");
        private Prodaja.Model.Nabavka _nabavka;

        public frmNovaNabavka(Prodaja.Model.Nabavka nabavka = null)
        {
            InitializeComponent();
            _nabavka = nabavka;
        }
        private async void frmNovaNabavka_Load(object sender, EventArgs e)
        {
            await LoadKorisnik();
            await LoadDobavljac();
            if (_nabavka != null)
            {
                txtBrojNabavke.Text = _nabavka.BrojNabavke;
                dtp_Datum.Value = _nabavka.Datum;
                txtCijena.Text = _nabavka.IznosRacuna.ToString();
                txt_Kolicina.Text = _nabavka.Kolicina.ToString();
                cmbDob.SelectedIndex = _nabavka.DobavljacId;
                cmbKorisnik.SelectedIndex = _nabavka.KorisnikId;
            }
        }
        private async Task LoadKorisnik()
        {
            var result = await _serviceKorisnici.GetAll<List<Prodaja.Model.Korisnici>>(null);
            cmbKorisnik.DataSource = result;
            result.Insert(0, new Prodaja.Model.Korisnici());
            cmbKorisnik.ValueMember = "KorisnikId";
            cmbKorisnik.DisplayMember = "Ime";
        }

        private async Task LoadDobavljac()
        {
            var result = await _serviceDob.GetAll<List<Prodaja.Model.Dobavljaci>>(null);
            cmbDob.DataSource = result;
            result.Insert(0, new Prodaja.Model.Dobavljaci());
            cmbDob.ValueMember = "DobavljacId";
            cmbDob.DisplayMember = "Naziv";
        }

        NabavkaInsertRequest insert = new NabavkaInsertRequest();
        NabavkaUpdateRequest update = new NabavkaUpdateRequest();
        private async void btn_Nabavka_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                insert.BrojNabavke = update.BrojNabavke = txtBrojNabavke.Text;
                insert.Datum = update.Datum = dtp_Datum.Value;

                if (decimal.TryParse(txtCijena.Text, out decimal IznosRacuna))
                {
                    insert.IznosRacuna = update.IznosRacuna = IznosRacuna;
                }
                else if (_nabavka != null)
                {
                    update.IznosRacuna = _nabavka.IznosRacuna;
                }


                var idobj = cmbKorisnik.SelectedValue;
                if (int.TryParse(idobj.ToString(), out int KorisnikId))
                {
                    insert.KorisnikId = update.KorisnikId = KorisnikId;
                }
                var dobobj = cmbDob.SelectedValue;
                if (int.TryParse(dobobj.ToString(), out int DobavljacId))
                {
                    insert.DobavljacId = update.DobavljacId = DobavljacId;
                }
                if (int.TryParse(txt_Kolicina.Text, out int Kolicina))
                {
                    insert.Kolicina = update.Kolicina = Kolicina;
                }
                if (_nabavka == null)
                {
                    await _service.Insert<Prodaja.Model.Nabavka>(insert);
                    MessageBox.Show("Nabavka sačuvana");
                    this.Close();
                }
                else
                {
                    await _service.Update<Prodaja.Model.Nabavka>(_nabavka.NabavkaId, update);
                    MessageBox.Show("Nabavka izmjenjena");
                    this.Close();
                }
            }
        }
        private bool ValidirajUnos()
        {
            return
                Validator.ValidirajKontrolu(cmbDob, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(cmbKorisnik, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtBrojNabavke, err, "Obavezna vrijednost");
        }
    }
}

