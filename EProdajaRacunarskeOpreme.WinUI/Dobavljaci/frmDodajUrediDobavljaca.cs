using EProdajaRacunarskeOpreme.WinUI.Helper;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProdajaRacunarskeOpreme.WinUI.Dobavljaci
{
    public partial class frmDodajUrediDobavljaca : Form
    {
        APIService _service = new APIService("Dobavljaci");
        private Prodaja.Model.Dobavljaci _dobavljaci;


        public frmDodajUrediDobavljaca(Prodaja.Model.Dobavljaci dobavljaci = null)
        {
            InitializeComponent();
            _dobavljaci = dobavljaci;
        }

        private void frmDodajUrediDobavljaca_Load(object sender, EventArgs e)
        {
            if (_dobavljaci != null)
            {
                txtNaziv.Text = _dobavljaci.Naziv;
                txtAdresa.Text = _dobavljaci.Adresa;
                txtEmail.Text = _dobavljaci.Email;
                txtFax.Text = _dobavljaci.Fax;
                txtKontaktOsoba.Text = _dobavljaci.KontaktOsoba;
                txtNapomena.Text = _dobavljaci.Napomena;
                txtTelefon.Text = _dobavljaci.Telefon;
                txtWeb.Text = _dobavljaci.Web;
                txtZiroRacuni.Text = _dobavljaci.ZiroRacuni;
                ck_Aktivan.Checked = _dobavljaci.Status;
                if (_dobavljaci.Slika != null && _dobavljaci.Slika.Length > 0)
                    pictureBox.Image = Helper.ImageHelper.FromByteToImage(_dobavljaci.Slika);
            }
        }
        DobavljaciInsertRequest insert = new DobavljaciInsertRequest();
        DobavljaciUpdateRequest update = new DobavljaciUpdateRequest();
        private async void btn_Korisnici_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                insert.Naziv = update.Naziv = txtNaziv.Text;
                insert.KontaktOsoba = update.KontaktOsoba = txtKontaktOsoba.Text;
                insert.Adresa = update.Adresa = txtAdresa.Text;
                insert.Telefon = update.Telefon = txtTelefon.Text;
                insert.Fax = txtFax.Text;
                insert.Web = txtWeb.Text;
                insert.Email = txtEmail.Text;
                insert.ZiroRacuni = txtZiroRacuni.Text;
                insert.Napomena = update.Napomena = txtNapomena.Text;
                insert.Status = update.Status = ck_Aktivan.Checked;
                if (pictureBox != null)
                {
                    insert.Slika = update.Slika = Helper.ImageHelper.FromImageToByte(pictureBox.Image);
                }
                else if(_dobavljaci != null) // zadrži staru sliku u slučaju da nova nije odabrana prilikom update-a
                {
                    update.Slika = _dobavljaci.Slika;
                }

                if (_dobavljaci == null)
                {
                    await _service.Insert<Prodaja.Model.Dobavljaci>(insert);
                    MessageBox.Show("Podaci sačuvani");
                    this.Close();
                }
                else
                {
                    await _service.Update<Prodaja.Model.Dobavljaci>(_dobavljaci.DobavljacId, update);
                    MessageBox.Show("Podaci izmjenjeni");
                    this.Close();
                }
            }

        }
        private bool ValidirajUnos()
        {
            return
                Validator.ValidirajKontrolu(txtNaziv, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtAdresa, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtTelefon, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtEmail, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(pictureBox, err, "Obavezna vrijednost");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                insert.Slika = file;
                txtSlikaInput.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
            }
        }
    }
}
