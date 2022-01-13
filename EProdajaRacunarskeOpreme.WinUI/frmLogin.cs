using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EProdajaRacunarskeOpreme.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService api = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                var result = await api.GetAll<List<Prodaja.Model.Korisnici>>(null);

                if (result != null)
                {
                    foreach (var korisnik in result)
                    {
                        if (korisnik.KorisnickoIme == APIService.Username)
                        {
                            APIService.PrijavljeniKorisnik = korisnik;

                            if (APIService.PrijavljeniKorisnik.KorisniciUloge.Any(x => x.Uloga.Naziv == "Prodavac"))
                            {
                                Form frm = new frmProdavac();
                                frm.Show();
                            }
                            else
                            {
                                Form frm = new frmPocetna();
                                frm.Show();
                            }
                            return;
                        }

                    }

                    throw new Exception("Korisnik nije pronađen.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
