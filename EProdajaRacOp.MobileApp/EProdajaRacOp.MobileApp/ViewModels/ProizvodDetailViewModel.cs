using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Prodaja.Model;
using System.Threading.Tasks;
using Prodaja.Model.Requests;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using EProdajaRacOp.MobileApp.Views;
using EProdajaRacOp.MobileApp.Services;

namespace EProdajaRacOp.MobileApp.ViewModels
{
    public class ProizvodDetailViewModel : BaseViewModel
    {
        private readonly APIService _proizvodiService = new APIService("Proizvodi");
        private readonly APIService _ocjeneService = new APIService("Ocjene");
        public ProizvodDetailViewModel()
        {
            PovecajKolicinuCommand = new Command(() =>
            {
                if (Kolicina < 10)
                    Kolicina += 1;
            }
            );
            SmanjiKolicinuCommand = new Command(() =>
            {
                if (Kolicina > 0)
                    Kolicina -= 1;
            });

            NaruciCommand = new Command(Naruci);
            InitCommand = new Command(async () => await Init());

            OcijeniSa1Command = new Command(async () => await Ocijeni(1));
            OcijeniSa2Command = new Command(async () => await Ocijeni(2));
            OcijeniSa3Command = new Command(async () => await Ocijeni(3));
            OcijeniSa4Command = new Command(async () => await Ocijeni(4));
            OcijeniSa5Command = new Command(async () => await Ocijeni(5));

        }
        public async Task Ocijeni(int ocjena)
        {
            OcjeneInsertRequest x = new OcjeneInsertRequest
            {
                ProizvodId = Proizvod.ProizvodId,
                KlijentId = APIService.PrijavljeniKlijent.KlijentId,
                Ocjena = ocjena,
                Datum = DateTime.Now
            };


            await _ocjeneService.Insert<Ocjene>(x);
            await UcitajOcjenu();

            await App.Current.MainPage.DisplayAlert("Uspješno ocijenjeno", "", "OK");


        }

        public Proizvodi Proizvod { get; set; }
        public ObservableCollection<Ocjene> OcjeneArtiklaList { get; set; } = new ObservableCollection<Ocjene>();



        public async Task Init()
        {
            await UcitajOcjenu();

        }

        private async Task UcitajOcjenu()
        {
            var listaocjena = await _ocjeneService.GetAll<List<Ocjene>>(null);
            Ocijenjeno = false;
            foreach (var item in listaocjena)
            {
                if (item.ProizvodId == Proizvod.ProizvodId)
                {
                    OcjeneArtiklaList.Add(item);
                    if (item.KlijentId == APIService.PrijavljeniKlijent.KlijentId)
                    {
                        Ocijenjeno = true;
                    }

                }
            }
            NijeOcijenjeno = !Ocijenjeno;
            if (OcjeneArtiklaList.Count() != 0)
            {
                ProsjecnaOcjena = OcjeneArtiklaList.Select(s => s.Ocjena).Average();
            }
            else
            {
                ProsjecnaOcjena = 0;
            }
        }

        int _kolicina = 0;

        public int Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand SmanjiKolicinuCommand { get; set; }

        public ICommand OcijeniSa1Command { get; set; }
        public ICommand OcijeniSa2Command { get; set; }
        public ICommand OcijeniSa3Command { get; set; }
        public ICommand OcijeniSa4Command { get; set; }
        public ICommand OcijeniSa5Command { get; set; }


        public ICommand NaruciCommand { get; set; }
        public ICommand InitCommand { get; set; }


        private void Naruci()
        {
            if (Kolicina > 0)
            {
                if (CartService.Cart.ContainsKey(Proizvod.ProizvodId))
                {
                    CartService.Cart.Remove(Proizvod.ProizvodId);
                }
                CartService.Cart.Add(Proizvod.ProizvodId, this);

                App.Current.MainPage.DisplayAlert("Uspjeh", "Uspjesno dodan artikal u korpu", "OK");

            }
            else
            {
                App.Current.MainPage.DisplayAlert("Greška", "Odaberite količinu proizvoda.", "OK");
            }

        }

        double _ProsjecnaOcjena;
        public double ProsjecnaOcjena
        {
            get { return _ProsjecnaOcjena; }
            set
            {
                SetProperty(ref _ProsjecnaOcjena, value);
            }
        }
        bool _Ocijenjeno;
        public bool Ocijenjeno
        {
            get { return _Ocijenjeno; }
            set
            {
                SetProperty(ref _Ocijenjeno, value);
            }
        }
        bool _NijeOcijenjeno;
        public bool NijeOcijenjeno
        {
            get { return _NijeOcijenjeno; }
            set
            {
                SetProperty(ref _NijeOcijenjeno, value);
            }
        }

    }
}
