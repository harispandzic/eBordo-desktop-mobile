using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using eBordo.Model.Helpers;
using eBordo.WinUI.Properties;
using Flurl.Http;

namespace eBordo.WinUI.ApiService
{
    public class ApiService
    {
        private string _resource;
        public string endpoint = $"{Properties.Settings.Default.ApiURL}";

        public static string username { get; set; }
        public static string password { get; set; }

        public static Model.Models.Korisnik logovaniKorisnik { get; set; }

        public ApiService(string resource)
        {
            _resource = resource;
        }
        public async Task<T> Auth<T>()
        {
            var url = $"{endpoint}{_resource}/Auth";

            try
            {
                return await url.WithBasicAuth(username, password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                throw;
            }
        }

        public async Task<T> GetRecommendedById<T>(string naziv, object request = null)
        {
            return await $"{endpoint}{_resource}/{naziv}".WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> GetAll<T>(object request = null)
        {
            var query = "";
            if (request != null)
            {
                query = await request?.ToQueryString();
            }

            var list = await $"{endpoint}{_resource}?{query}".WithBasicAuth(username,password).GetJsonAsync<T>();

            return list;
        }
        public async Task<T> GetById<T>(object id)
        {
            var result = await $"{endpoint}{_resource}/{id}".WithBasicAuth(username, password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> DeleteById<T>(object id)
        {
            var result = await $"{endpoint}{_resource}/{id}".WithBasicAuth(username, password).DeleteAsync().ReceiveJson<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            return await $"{endpoint}{_resource}".WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(int id, object request)
        {
            return await $"{endpoint}{_resource}/{id}".WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();
        }
    }
}
