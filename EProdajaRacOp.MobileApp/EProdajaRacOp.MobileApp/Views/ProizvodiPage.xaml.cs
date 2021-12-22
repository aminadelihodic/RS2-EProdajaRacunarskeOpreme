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
    public partial class ProizvodiPage : ContentPage
    {

        private ProizvodiViewModel proizvodiViewModel = null;
        public ProizvodiPage()
        {
            InitializeComponent();
            BindingContext = proizvodiViewModel = new ProizvodiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await proizvodiViewModel.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var proizvod = e.Item as Proizvodi;

            await Navigation.PushAsync(new ProizvodDetaljiPage(proizvod));
        }
    }
}