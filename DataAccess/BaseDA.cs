using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DataAccess
{
    public class BaseDA
    {
        #region Constants
        public const string BaseURI = "";
        #endregion

        public async static void PostCall<T>(T item, string URI)
        {
            var uri = new Uri(string.Format($"{BaseURI}{URI}"));
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            HttpClient client = new HttpClient() { BaseAddress = uri };
            response = await client.PostAsync(uri, content);
            if (response.IsSuccessStatusCode)
            {
                //Navigate to home page
            }
        }
    }
}
