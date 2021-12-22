using EProdajaRacunarskeOpreme.WinUI.Helper;
using Prodaja.Model;
using Prodaja.Model.Requests;
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

namespace EProdajaRacunarskeOpreme.WinUI.Proizvodi
{
    public partial class frmDodajUrediProizvod : Form
    {
        private readonly APIService _service = new APIService("Proizvodi");
        private readonly APIService _serviceVrste = new APIService("VrsteProizvoda");
        private readonly APIService _serviceProizvodjaci = new APIService("Proizvodjaci");

        private Prodaja.Model.Proizvodi _proizvodi;
        public frmDodajUrediProizvod(Prodaja.Model.Proizvodi proizvodi = null)
        {
            InitializeComponent();
            _proizvodi = proizvodi;
        }

        private async void frmDodajUrediProizvod_Load(object sender, EventArgs e)
        {
            await UcitajVrsteProizvoda();
            await UcitajProizvodjaca();
            if (_proizvodi != null)
            {
                txtNaziv.Text = _proizvodi.Naziv;
                txtSifra.Text = _proizvodi.Sifra;
                txtCijena.Text = _proizvodi.Cijena.ToString();
                if (_proizvodi.Status == true) { ck_Status.Checked = true; }
                cmbVrstaProizvoda.SelectedIndex = _proizvodi.VrstaProizvodaId;
                cmbProizvodjac.SelectedIndex = _proizvodi.ProizvodjacId;
                if (_proizvodi.Slika != null && _proizvodi.Slika.Length > 0)
                    pictureBox.Image = Helper.ImageHelper.FromByteToImage(_proizvodi.Slika);

            }
        }

        private async Task UcitajProizvodjaca()
        {
            var result = await _serviceProizvodjaci.GetAll<List<Prodaja.Model.Proizvodjaci>>(null);
            cmbProizvodjac.DataSource = result;
            result.Insert(0, new Prodaja.Model.Proizvodjaci());
            cmbProizvodjac.ValueMember = "ProizvodjacId";
            cmbProizvodjac.DisplayMember = "Naziv";
        }

        private async Task UcitajVrsteProizvoda()
        {
            var result = await _serviceVrste.GetAll<List<Prodaja.Model.VrsteProizvoda>>(null);
            cmbVrstaProizvoda.DataSource = result;
            result.Insert(0, new Prodaja.Model.VrsteProizvoda());
            cmbVrstaProizvoda.ValueMember = "VrstaProizvodaId";
            cmbVrstaProizvoda.DisplayMember = "Naziv";

        }
        ProizvodiInsertRequest insert = new ProizvodiInsertRequest();
        ProizvodiUpdateRequest update = new ProizvodiUpdateRequest();
        private async void btn_Proizvodi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                var idobj = cmbVrstaProizvoda.SelectedValue;
                if (int.TryParse(idobj.ToString(), out int VrstaProizvodaId))
                {
                    insert.VrstaProizvodaId = update.VrstaProizvodaId = VrstaProizvodaId;
                }
                var proizvodjacObj = cmbProizvodjac.SelectedValue;
                if (int.TryParse(proizvodjacObj.ToString(), out int ProizvodjacId))
                {
                    insert.ProizvodjacId = update.ProizvodjacId = ProizvodjacId;
                }
                insert.Naziv = update.Naziv = txtNaziv.Text;
                insert.Sifra = update.Sifra = txtSifra.Text;
                if (decimal.TryParse(txtCijena.Text, out decimal Cijena))
                {
                    insert.Cijena = update.Cijena = Cijena;
                }
                else if (_proizvodi != null)
                {
                    update.Cijena = _proizvodi.Cijena;
                }
                insert.Status = update.Status = ck_Status.Checked;
                if (pictureBox != null)
                {
                    insert.Slika = update.Slika = Helper.ImageHelper.FromImageToByte(pictureBox.Image);
                }
                if (_proizvodi == null)
                {
                    await _service.Insert<Prodaja.Model.Proizvodi>(insert);
                    MessageBox.Show("Podaci sačuvani");
                    this.Close();
                }
                else
                {
                    await _service.Update<Prodaja.Model.Proizvodi>(_proizvodi.ProizvodId, update);
                    MessageBox.Show("Podaci izmjenjeni");
                    this.Close();
                }
            }

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
        private bool ValidirajUnos()
        {
            return
                Validator.ValidirajKontrolu(pictureBox, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(txtNaziv, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(cmbProizvodjac, err, "Obavezna vrijednost") &&
                Validator.ValidirajKontrolu(cmbVrstaProizvoda, err, "Obavezna vrijednost");
        }


    }
}
