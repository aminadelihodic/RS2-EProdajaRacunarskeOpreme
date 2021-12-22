using EProdajaRacOp.MobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EProdajaRacOp.MobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}