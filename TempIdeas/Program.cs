using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempIdeas.ConfigMappers;
using TempIdeas.UriGenerators;

namespace TempIdeas
{
    class Program
    {
        static void Main(string[] args)
        {
            UriConfigManager uriConfigManager = new UriConfigManager("weatherServiceApiConfig");
            UriGenerator uriGenerator = new UriGenerator(uriConfigManager.UriConfig);
            Console.WriteLine(uriGenerator.Uri);
            Console.ReadLine();
        }
    }
}
