using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Prodaja.Model;
using System.Windows.Forms;
using EProdajaRacunarskeOpreme.WinUI.Properties;

namespace EProdajaRacunarskeOpreme.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Prodaja.Model.Korisnici PrijavljeniKorisnik { get; set; }

        private readonly string _route;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> GetAll<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani");
                    return default;
                }
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Niste autorizovani");
                    return default;
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani");
                    return default;
                }
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Niste autorizovani");
                    return default;
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani");
                    return default;
                }
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Niste autorizovani");
                    return default;
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }
        //private string _resource;
        //public string endpoint = $"{Resources.ApiUrl}";

        //public static string Username { get; set; }
        //public static string Password { get; set; }

        //public APIService(string resource)
        //{
        //    _resource = resource;
        //}
        //public async Task<T> GetAll<T>(object searchRequest = null)
        //{
        //    var query = "";
        //    if (searchRequest != null)
        //    {
        //        query = await searchRequest?.ToQueryString();
        //    }

        //    var list = await $"{endpoint}{_resource}?{query}"
        //       .WithBasicAuth(Username, Password).GetJsonAsync<T>();

        //    return list;
        //}

        //public async Task<T> GetById<T>(object id)
        //{
        //    var url = $"{endpoint}{_resource}/{id}";

        //    return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        //}

        //public async Task<T> Insert<T>(object request)
        //{
        //    var url = $"{endpoint}{_resource}";

        //    try
        //    {
        //        return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        //    }
        //    catch (FlurlHttpException ex)
        //    {
        //        var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

        //        var stringBuilder = new StringBuilder();
        //        foreach (var error in errors)
        //        {
        //            stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
        //        }

        //        MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return default(T);
        //    }

        //}

        //public async Task<T> Update<T>(int id, object request)
        //{
        //    try
        //    {
        //        var url = $"{endpoint}{_resource}/{id}";

        //        return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        //    }
        //    catch (FlurlHttpException ex)
        //    {
        //        var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

        //        var stringBuilder = new StringBuilder();
        //        foreach (var error in errors)
        //        {
        //            stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
        //        }

        //        MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return default(T);
        //    }

        //}
    }
}