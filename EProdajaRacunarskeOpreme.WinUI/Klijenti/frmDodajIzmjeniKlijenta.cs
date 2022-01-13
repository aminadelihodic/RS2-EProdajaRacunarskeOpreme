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

namespace EProdajaRacunarskeOpreme.WinUI.Klijenti
{
    public partial class frmDodajIzmjeniKlijenta : Form
    {
        APIService _service = new APIService("Klijenti");
        private Prodaja.Model.Klijenti _klijenti;


        public frmDodajIzmjeniKlijenta(Prodaja.Model.Klijenti klijenti = null)
        {
            InitializeComponent();
            _klijenti = klijenti;
        }

        private async void btn_Korisnici_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if (_klijenti == null)
                {
                    //insert
                    KlijentiInsertRequest request = new KlijentiInsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        DatumRegistracije = dtp_Datum.Value,
                        Password = txtLozinka.Text,
                        PasswordPotvrda = txtLozinkaPotvrda.Text
                    };

                    var klijenti = await _service.Insert<Prodaja.Model.Klijenti>(request);
                    if (klijenti != null)
                    {
                        MessageBox.Show("Podaci sačuvani");
                        this.Close();
                    }
                }
                else
                {
                    //update
                    KlijentiUpdateRequest request = new KlijentiUpdateRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Telefon = txtTelefon.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        DatumRegistracije = dtp_Datum.Value,
                        Email = txtEmail.Text,
                        Password = txtLozinka.Text,
                        PasswordPotvrda = txtLozinkaPotvrda.Text
                    };

                    var klijenti = await _service.Update<Prodaja.Model.Klijenti>(_klijenti.KlijentId, request);
                    if (klijenti != null)
                    {
                        MessageBox.Show("Podaci izmjenjeni");
                        this.Close();
                    }
                }
            }
        }
        private void frmDodajIzmjeniKlijenta_Load(object sender, EventArgs e)
        {
            if (_klijenti != null)
            {

                txtIme.Text = _klijenti.Ime;
                txtPrezime.Text = _klijenti.Prezime;
                txtEmail.Text = _klijenti.Email;
                txtTelefon.Text = _klijenti.Telefon;
                txtKorisnickoIme.Text = _klijenti.KorisnickoIme;
                dtp_Datum.Value = _klijenti.DatumRegistracije;
            }
        }
        private bool ValidirajUnos()
        {
            return
                Validator.ValidirajKontrolu(txtKorisnickoIme, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtIme, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtPrezime, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtEmail, err, "Obavezna vrijednost");
            ;
        }
    }
}
