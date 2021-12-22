using EProdajaRacOp.MobileApp.Views;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EProdajaRacOp.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _serviceKlijenti = new APIService("Klijenti");
        

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set
            {
                SetProperty(ref _password, value);
            }
        }
        public ICommand LoginCommand { get; set; }
        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                var korisnici = await _serviceKlijenti.GetAll<List<Klijenti>>(null);
                if(korisnici != null)
                {
                    foreach (var korisnik in korisnici)
                    {
                        if (korisnik.KorisnickoIme == Username)
                        {
                            APIService.PrijavljeniKlijent = korisnik;
                            Application.Current.MainPage = new AppShell();
                            return;
                        }
                    }

                    throw new Exception("Klijent nije pronađen");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
        }

    }
}
