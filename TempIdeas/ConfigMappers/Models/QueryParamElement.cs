using System.Configuration;

namespace TempIdeas.ConfigMappers.Models
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
        public string Value
        {
            get { return (string)base["value"]; }
            set { base["value"] = value; }
        }
    }
}
