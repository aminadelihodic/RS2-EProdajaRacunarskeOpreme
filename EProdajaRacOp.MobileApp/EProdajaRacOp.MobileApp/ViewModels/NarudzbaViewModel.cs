using EProdajaRacOp.MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EProdajaRacOp.MobileApp.ViewModels
{
    public class NarudzbaViewModel : BaseViewModel
    {

        public ObservableCollection<ProizvodDetailViewModel> NarudzbaList { get; set; } = new ObservableCollection<ProizvodDetailViewModel>();


        decimal _brojProizvoda = 0;

        public decimal BrojProizvoda
        {
            get { return _brojProizvoda; }
            set { SetProperty(ref _brojProizvoda, value); }
        }
        decimal _iznos = 0;

        public decimal Iznos
        {
            get { return _iznos; }
            set { SetProperty(ref _iznos, value); }
        }

        public void Init()
        {


            foreach (var item in CartService.Cart.Values)
            {

                NarudzbaList.Add(item);





            }
            Iznos = 0;
            foreach (var item in NarudzbaList)
            {

                Iznos += item.Kolicina * item.Proizvod.Cijena;
            }

            BrojProizvoda = NarudzbaList.Count();



            CartService.Cart.Clear();

        }
    }
}
