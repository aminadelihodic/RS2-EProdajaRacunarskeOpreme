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
    public partial class ProizvodDetaljiPage : ContentPage
    {
        private ProizvodDetailViewModel model = null;

        public ProizvodDetaljiPage(Proizvodi proizvod)
        {
            BindingContext = model = new ProizvodDetailViewModel
            {
                Proizvod = proizvod

            };
            InitializeComponent();


        }

   
        protected override async void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();
        }

    }
}