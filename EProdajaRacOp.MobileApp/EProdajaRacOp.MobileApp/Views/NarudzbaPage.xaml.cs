using EProdajaRacOp.MobileApp.Converter;
using EProdajaRacOp.MobileApp.Services;
using EProdajaRacOp.MobileApp.ViewModels;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EProdajaRacOp.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NarudzbaPage : ContentPage
    {
        
        private NarudzbaViewModel model = null;
        private APIService _service = new APIService("Narudzba");
        public NarudzbaPage()
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();

        }

        private async void Zakljuci_Clicked(object sender, EventArgs e)
        {
            if (model.NarudzbaList.Count == 0)
            {
                await DisplayAlert("Greška", "Nije moguće zaključiti praznu narudžbu.", "OK");
                return;
            }

            List<Narudzba> list = await _service.GetAll<List<Narudzba>>(null);
            int najveci = int.MinValue;
            foreach (var item in list)
            {

                if (item.NarudzbaId > najveci)
                {
                    najveci = item.NarudzbaId;
                }
            }
            int BrojNarudzbe = najveci + 1;


            string neki = Generisi.GenerisiBrojNarudzbe(BrojNarudzbe);


            NarudzbaInsertRequest request = new NarudzbaInsertRequest();

            request.BrojNarudzbe = neki;
            request.Datum = DateTime.Now;
            request.KlijentId = APIService.PrijavljeniKlijent.KlijentId;
            request.Status = false;
            request.IznosRacuna = model.NarudzbaList.Sum(x => x.Proizvod.Cijena * x.Kolicina);
            request.Otkazano = false;
            request.stavke = new List<NarudzbaStavkeInsertRequest>();

            foreach (var item in model.NarudzbaList)
            {
                NarudzbaStavkeInsertRequest stavka = new NarudzbaStavkeInsertRequest();

                stavka.ProizvodId = item.Proizvod.ProizvodId;
                stavka.Cijena = item.Proizvod.Cijena;
                stavka.Kolicina = item.Kolicina;
                stavka.Popust = 0;

                request.stavke.Add(stavka);
            }

            var narudzba = await _service.Insert<Narudzba>(request);

            await DisplayAlert("Uspjeh", "Uspjesno ste napravili novu narudzbu", "OK");
            model.NarudzbaList.Clear();
            CartService.Cart.Clear();

            model.Init();

            await Navigation.PushAsync(new UplatiNarudžbuPage(model.Iznos, narudzba.NarudzbaId));

        }

        private async void Otkazi_Clicked(object sender, EventArgs e)
        {
            if (model.NarudzbaList.Count == 0)
            {
                await DisplayAlert("Greška", "Nije moguće otkazati praznu narudžbu.", "OK");
                return;
            }

            model.NarudzbaList.Clear();
            CartService.Cart.Clear();

            model.Init();

            await DisplayAlert("Uspjeh", "Narudžba je uspješno otkazana.", "OK");

        }
    }
}
