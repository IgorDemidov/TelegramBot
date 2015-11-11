using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace LoremBot.Providers
{
    public class WeatherJsonObjectProvider
    {
//        public void Get()
//        {
//            UriBuilder baseUri = new UriBuilder("http://api.openweathermap.org/data/2.5/weather");
//            string queryToAppend = "param2=1234";

//if (baseUri.Query != null && baseUri.Query.Length > 1)
//    baseUri.Query = baseUri.Query.Substring(1) + "&" + queryToAppend; 
//else
//    baseUri.Query = queryToAppend; 

//            Uri uri = uriBuilder.Uri;
            
//            string url = string.Format(
//                "http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&units=metric",
//                "Minsk",
//                "ec259b32688dc1c1d087ebc30cbff9ed");

//            WebRequest request = WebRequest.Create(url);
//            WebResponse response = request.GetResponse();
//            using (var streamReader = new StreamReader(response.GetResponseStream()))
//            {
//                string responseString = streamReader.ReadToEnd();
//                JObject joResponse = JObject.Parse(responseString);
//            }
//        }
    }
}
