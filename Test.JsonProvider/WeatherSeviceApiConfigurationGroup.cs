using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Test
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
