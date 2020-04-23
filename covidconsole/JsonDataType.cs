using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covidconsole
{
  public  class JsonDataType
    {


        public string Global { get; set; }
        public string Country { get; set; }
        public int NewConfirmed { get; set; }

        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }

        public int TotalRecovered { get; set; }
    }
}
