using System;
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

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            WeatherSeviceApiConfigurationGroup myConfiguration = (WeatherSeviceApiConfigurationGroup)config.GetSectionGroup("my.configuration");
            UriConfigSection section = myConfiguration.UriConfig;
            Console.ReadLine();
        }
    }
}
