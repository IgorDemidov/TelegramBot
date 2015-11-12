using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class UriConfigManager
    {
        public UriConfig UriConfig { get; private set; }

        public UriConfigManager(string appConfigSectionName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            WeatherSeviceApiConfigurationGroup configGroup = (WeatherSeviceApiConfigurationGroup)config.GetSectionGroup(appConfigSectionName);
            this.UriConfig = configGroup.UriConfig;
        }     
    }
}
