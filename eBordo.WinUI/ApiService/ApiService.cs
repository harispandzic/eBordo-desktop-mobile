using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBordo.Model.Helpers;
using eBordo.WinUI.Properties;
using Flurl.Http;

namespace eBordo.WinUI.ApiService
{
    public class ApiService
    {
        private string _resource;
        public string endpoint = $"{Properties.Settings.Default.ApiURL}";

        public ApiService(string resource)
        {
            _resource = resource;
        }
        public async Task<T> GetAll<T>(object request = null)
        {
            var query = "";
            if (request != null)
            {
                query = await request?.ToQueryString();
            }

            var list = await $"{endpoint}{_resource}?{query}".GetJsonAsync<T>();

            return list;
        }
        public async Task<T> GetById<T>(object id)
        {
            var result = await $"{endpoint}{_resource}/{id}".GetJsonAsync<T>();
            return result;
        }
        public async Task<T> DeleteById<T>(object id)
        {
            var result = await $"{endpoint}{_resource}/{id}".DeleteAsync().ReceiveJson<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            return await $"{endpoint}{_resource}".PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(int id, object request)
        {
            return await $"{endpoint}{_resource}/{id}".PutJsonAsync(request).ReceiveJson<T>();
        }
    }
}
