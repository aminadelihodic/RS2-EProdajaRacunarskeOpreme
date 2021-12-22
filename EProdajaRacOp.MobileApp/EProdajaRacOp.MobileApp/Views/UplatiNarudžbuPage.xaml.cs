﻿using EProdajaRacOp.MobileApp.ViewModels;
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
    public partial class UplatiNarudžbuPage : ContentPage
    {
       
        private UplatiNarudžbuViewModel model;

        public UplatiNarudžbuPage(decimal Iznos, int NarudzbaId)
        {
            InitializeComponent();
            BindingContext = model = new UplatiNarudžbuViewModel()
            {
                Iznos = Iznos,
                NarudzbaId = NarudzbaId
            };

            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected  override void OnAppearing()
        {
            Submit_Button.IsEnabled = false;
            ErrorLabel_CardNumber.IsVisible = false;
            ErrorLabel_Cvv.IsVisible = false;
            ErrorLabel_Month.IsVisible = false;
            ErrorLabel_Year.IsVisible = false;

        }
        private void CardNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CardNumber.Text.Length > 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                CardNumber.Text = RemoveLastCharacter(CardNumber.Text);
                ErrorLabel_CardNumber.Text = "Nevalidan broj kartice";
            }
            else if (CardNumber.Text.Length < 1)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Broj kartice ne može biti prazan !!";

            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
                EnableSubmitButton();
            }

        }
        private void CardNumber_Completed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(CardNumber.Text) || CardNumber.Text.Length > 16 || CardNumber.Text.Length < 12)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Neispravan broj kartice";

            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
                CardNumber.Unfocus();
                Month.Focus();
                EnableSubmitButton();
            }

        }

        private void Month_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Month.Text))
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Mjesec ne može biti prazan !!";
            }
            else if (Month.Text.Length > 2)
            {
                Month.Text = RemoveLastCharacter(Month.Text);
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Nevalidan mjesec !!";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
                EnableSubmitButton();
            }

        }
        private void Month_Completed(object sender, System.EventArgs e)
        {
            Month.Unfocus();
            Year.Focus();
        }

        private void Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Year.Text))
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Godina ne može biti prazna !!";
            }
            else if (Year.Text.Length > 2)
            {
                Year.Text = RemoveLastCharacter(Year.Text);
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Nevalidna godina !!";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
                EnableSubmitButton();
            }

        }
        private void Year_Completed(object sender, System.EventArgs e)
        {
            Year.Unfocus();
            Cvv.Focus();
        }

        private void Cvv_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Cvv.Text))
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "CVV can not be empty !!";
            }
            else if (Cvv.Text.Length > 3)
            {
                Cvv.Text = RemoveLastCharacter(Cvv.Text);
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Invalid Cvv !!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
                EnableSubmitButton();
            }


        }
        private void Cvv_Completed(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(Cvv.Text))
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "CVV can not be empty !!";
            }
            else if (Cvv.Text.Length > 3)
            {
                Cvv.Text = RemoveLastCharacter(Cvv.Text);
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Invalid Cvv !!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
                EnableSubmitButton();
                Cvv.Unfocus();
            }
        }

        private void EnableSubmitButton()
        {
            if (ErrorLabel_CardNumber.IsVisible || ErrorLabel_Cvv.IsVisible || ErrorLabel_Month.IsVisible || ErrorLabel_Year.IsVisible)
            {
                Submit_Button.IsEnabled = false;
            }
            else
            {
                Submit_Button.IsEnabled = true;
            }
        }
        private string RemoveLastCharacter(string str)
        {
            int l = str.Length;
            string text = str.Remove(l - 1, 1);
            return text;
        }
    }
}
