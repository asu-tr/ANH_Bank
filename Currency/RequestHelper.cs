using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ANH_Bank.Currency
{
    public static class RequestHelper
    {
        public const string BaseUrl = "https://free.currconv.com/api/v7/";

        public static double ExchangeRate(CurrencyType from, CurrencyType to, string apiKey)
        {
            string url = BaseUrl + "convert?q=" + from + "_" + to + "&compact=y&apiKey=" + apiKey;

            var jsonString = GetResponse(url);
            return JObject.Parse(jsonString).First.First["val"].ToObject<double>();
        }

        private static string GetResponse(string url)
        {
            string jsonString;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            return jsonString;
        }
    }
}