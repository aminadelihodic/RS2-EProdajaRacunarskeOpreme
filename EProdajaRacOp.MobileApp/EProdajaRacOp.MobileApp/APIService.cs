﻿using Flurl.Http;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EProdajaRacOp.MobileApp
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Klijenti PrijavljeniKlijent { get; set; }

        private readonly string _route;

#if DEBUG
        private string _apiUrl = "http://localhost:5000/api";
#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.azure.com/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> GetAll<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search?.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                    return default;
                }
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autorizovani", "OK");
                    return default;
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                    return default;
                }
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autorizovani", "OK");
                    return default;
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                    return default;
                }
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autorizovani", "OK");
                    return default;
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }
    }
}
