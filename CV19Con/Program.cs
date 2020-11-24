﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CV19Con
{
    class Program
    {
        const string data_url = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";

        static void Main(string[] args)
        {
            //WebClient client = new WebClient();
            var client = new HttpClient();
            var resonse = client.GetAsync(data_url).Result;
            string csv_str = resonse.Content.ReadAsStringAsync().Result;

            Console.ReadLine();
        }
    }
}
