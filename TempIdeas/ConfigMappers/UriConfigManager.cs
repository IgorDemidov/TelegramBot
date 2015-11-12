using System.Configuration;
using TempIdeas.ConfigMappers.Models;

namespace TempIdeas.ConfigMappers
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


