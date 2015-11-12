using System.Configuration;

namespace TempIdeas.ConfigMappers.Models
{
    public class WeatherSeviceApiConfigurationGroup: ConfigurationSectionGroup
    {
        [ConfigurationProperty("uriConfig")]
        public UriConfig UriConfig
        {
            get { return (UriConfig)base.Sections["uriConfig"]; }
        }
    }
}
