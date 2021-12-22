using EProdajaRacOp.MobileApp.Services;
using EProdajaRacOp.MobileApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EProdajaRacOp.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new LoginPage();

            Stripe.StripeConfiguration.ApiKey = "sk_test_51K8umuEn3uZnEkBHpumBqmIVkYTImPi4dHiMLFFYoy7i17gqYIkgtJGLIC8l052N2l8K0fVXbLsj0ZWcgo1DOIIW00Xxx4MMx1";
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
