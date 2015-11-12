using System.Configuration;

namespace TempIdeas.ConfigMappers.Models
{
    public class ValueElement: ConfigurationElement
    {
        [ConfigurationProperty("value")]
        public string Value
        {
            get { return (string)base["value"]; }
            set { base["value"] = value; }
        }
    }
}
