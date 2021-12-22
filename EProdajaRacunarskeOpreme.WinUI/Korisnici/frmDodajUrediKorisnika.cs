using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EProdajaRacunarskeOpreme.WinUI.Helper;
using Prodaja.Model;
using Prodaja.Model.Requests;

namespace EProdajaRacunarskeOpreme.WinUI.Korisnici
{
    public partial class frmDodajUrediKorisnika : Form
    {
        APIService _service = new APIService("Korisnici");
        APIService ulogeService = new APIService("Uloge");
        private Prodaja.Model.Korisnici _korisnici;
        public frmDodajUrediKorisnika(Prodaja.Model.Korisnici korisnici = null)
        {
            InitializeComponent();
            _korisnici = korisnici;
        }


        private void frmDodajUrediKorisnika_Load(object sender, EventArgs e)
        {
            if (_korisnici != null)
            {

                txtIme.Text = _korisnici.Ime;
                txtPrezime.Text = _korisnici.Prezime;
                txtEmail.Text = _korisnici.Email;
                txtTelefon.Text = _korisnici.Telefon;
                txtKorisnickoIme.Text = _korisnici.KorisnickoIme;
                ck_Aktivan.Checked = _korisnici.Status;
            }
        }

        private async void btn_Korisnici_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if (_korisnici == null)
                {
                    KorisniciInsertRequest request = new KorisniciInsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Password = txtLozinka.Text,
                        PasswordPotvrda = txtLozinkaPotvrda.Text,
                        Status = ck_Aktivan.Checked
                    };
                    var korisnik = await _service.Insert<Prodaja.Model.Korisnici>(request);
                    if (korisnik != null)
                    {
                        MessageBox.Show("Podaci sačuvani");
                        this.Close();
                    }
                }
                else
                {
                    //update
                    KorisniciUpdateRequest request = new KorisniciUpdateRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Status = ck_Aktivan.Checked,
                        Email = txtEmail.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Telefon = txtTelefon.Text,
                        Password = txtLozinka.Text,
                        PasswordPotvrda = txtLozinkaPotvrda.Text
                    };
                    var korisnik = await _service.Update<Prodaja.Model.Korisnici>(_korisnici.KorisnikId, request);
                    if (korisnik != null)
                    {
                        if (korisnik.KorisnikId == APIService.PrijavljeniKorisnik.KorisnikId)
                        {
                            APIService.Username = txtKorisnickoIme.Text;
                            if (!string.IsNullOrEmpty(txtLozinka.Text))
                            {
                                APIService.Password = txtLozinka.Text;
                            }
                            APIService.PrijavljeniKorisnik = korisnik;
                        }
                        MessageBox.Show("Podaci izmjenjeni");
                        this.Close();
                    }
                }
            }
        }
            private bool ValidirajUnos()
            {
                return
                    Validator.ValidirajKontrolu(txtIme, err, "Obavezna vrijednost") &&
                    Validator.ValidirajKontrolu(txtPrezime, err, "Obavezna vrijednost") &&
                    Validator.ValidirajKontrolu(txtKorisnickoIme, err, "Obavezna vrijednost") &&
                    Validator.ValidirajKontrolu(txtEmail, err, "Obavezna vrijednost");
            }
        }
    }
