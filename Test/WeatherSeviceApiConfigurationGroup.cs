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
        public UriConfigSection UriConfig
        {
            get { return (UriConfigSection)base.Sections["uriConfig"]; }
        }
    }
}
