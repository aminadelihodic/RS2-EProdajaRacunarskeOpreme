using EProdajaRacOp.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EProdajaRacOp.MobileApp.Services
{
    public class CartService
    {
        public static Dictionary<int, ProizvodDetailViewModel> Cart = new Dictionary<int, ProizvodDetailViewModel>();
    }
}
