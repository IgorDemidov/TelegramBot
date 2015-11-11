using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class QueryParamElement: ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public string Name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("paramName")]
        public string ParamName
        {
            get { return (string)base["paramName"]; }
            set { base["paramName"] = value; }
        }

        [ConfigurationProperty("value")]
        public int Value
        {
            get { return (int)base["value"]; }
            set { base["value"] = value; }
        }
    }
}
