using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
   public class Results
    {

        public static List<string> comboBoxValue()
        {
            List<string> country = new List<string>();
            

            foreach (var item in CountryCase())
            {
                country.Add(item["Country"].ToString());


            }
            
            return country;


        }
        public static JArray CountryCase()
        {
            WebClient webber = new WebClient();
            string downloadStringer = webber.DownloadString(@"https://api.covid19api.com/summary");

            JToken token = JToken.Parse(downloadStringer);
            JArray men = (JArray)token.SelectToken("Countries");
            return men;

        }



    }
}
