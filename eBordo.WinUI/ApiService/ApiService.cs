using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBordo.Model.Helpers;

namespace eBordo.WinUI.ApiService
{
    public class ApiService
    {
        private string _route { get; set; }
        public ApiService(string route)
        {
            _route = route;
        }
        //public async Task<T> Get<T>(object requestq)
        //{
        //    var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
        //    if (requestq != null)
        //    {
        //        url += "?";
        //        url += await requestq.ToQueryString();
        //    }

        //    var result = await url.GetJsonAsync<T>();
        //    return result;
        //}
        //public async Task<T> GetById<T>(object id)
        //{
        //    var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";

        //    var result = await url.GetJsonAsync<T>();
        //    return result;
        //}
    }
}
