using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace covidconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webclient = new WebClient();
            string dataP = webclient.DownloadString(@"https://api.covid19api.com/summary");
            List<string> jpersOn = JsonConvert.DeserializeObject<List<string>>(dataP);
            Console.WriteLine(jpersOn.Count);
            Console.ReadLine();
        }
    }
}
