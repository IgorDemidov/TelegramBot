﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            UriConfigManager configManager = new UriConfigManager("weatherServiceApiConfig");

            foreach (QueryParamElement p in configManager.UriConfig.QueryParams)
            {
                string queryStringPartial = p.ParamName = p.Value;
                Console.WriteLine("{0}:\t{1}", p.Name, queryStringPartial);
            }
            Console.ReadLine();
        }
    }
}
