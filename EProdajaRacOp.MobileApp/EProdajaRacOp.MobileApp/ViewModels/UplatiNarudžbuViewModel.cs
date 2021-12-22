using Acr.UserDialogs;
using EProdajaRacOp.MobileApp.Models;
using EProdajaRacOp.MobileApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EProdajaRacOp.MobileApp.ViewModels
{
    public class UplatiNarudžbuViewModel : BindableBase
    {

        #region Variable
        private readonly APIService _serviceNarudzba = new APIService("Narudzba");


        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;

        private bool _isCarcValid;
        private bool _isTransactionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        #endregion Variable

        #region Public Property


        
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransactionSuccess
        {
            get { return _isTransactionSuccess; }
            set { SetProperty(ref _isTransactionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        decimal _iznos = 0;
        public decimal Iznos
        {
            get { return _iznos; }
            set { SetProperty(ref _iznos, value); }
        }
        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        
        #endregion Public Property

        #region Constructor

        public UplatiNarudžbuViewModel()
        {
            CreditCardModel = new CreditCardModel();
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {

            

            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Obrada u toku..");
                await Task.Run( () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransactionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Neispravni podaci za uplatu.", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");

            }
            finally
            {
                if (IsTransactionSuccess)
                {
                    UserDialogs.Instance.HideLoading();

                    var Narudzba = await _serviceNarudzba.GetById<Prodaja.Model.Narudzba>(NarudzbaId);
                    if(Narudzba != null)
                    {
                        var entity = await _serviceNarudzba.Update<Prodaja.Model.Narudzba>(NarudzbaId, new Prodaja.Model.NarudzbaUpdateRequest
                        {
                            BrojNarudzbe = Narudzba.BrojNarudzbe,
                            Datum = Narudzba.Datum,
                            IznosRacuna = Narudzba.IznosRacuna,
                            KlijentId = Narudzba.KlijentId,
                            Otkazano = Narudzba.Otkazano,
                            Status = true
                        });
                        if (entity != null)
                        {
                            await Shell.Current.GoToAsync("///" + nameof(NarudzbaPage));
                        }
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Narudžba nije pronađena", null, "OK");
                    }


                }
            }

        });
        public int NarudzbaId { get; set; }
        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = APIService.PrijavljeniKlijent.Ime,
                        Currency = "USD",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public bool MakePayment(string token)
        {
            try
            {
                var options = new ChargeCreateOptions
                {
                    Amount = ((long)Iznos) * 100,
                    Currency = "USD",
                    Description = $"Uplata narudžbe za {APIService.PrijavljeniKlijent}",
                    Source = stripeToken.Id,
                    Capture = true,
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gateway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }



        #endregion Method
    }

}
