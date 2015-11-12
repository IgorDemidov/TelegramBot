using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.JsonProvider
{
    class Program
    {
        static void Main(string[] args)
        {

            UriConfigManager configManager = new UriConfigManager("weatherServiceApiConfig");

            UriGenerator uriGen = new UriGenerator(configManager.UriConfig);
            Console.WriteLine(uriGen.Uri.ToString());
            Console.ReadLine();
        }
    }
}
