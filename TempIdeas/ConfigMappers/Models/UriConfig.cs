using System.Configuration;

namespace TempIdeas.ConfigMappers.Models
{
    public class UriConfig: ConfigurationSection
    {
        [ConfigurationProperty("scheme")]
        public ValueElement Scheme
        {
            get { return ((ValueElement)base["scheme"]); }
        }

        [ConfigurationProperty("host")]
        public ValueElement Host
        {
            get { return ((ValueElement)base["host"]); }
        }

        [ConfigurationProperty("path")]
        public ValueElement Path
        {
            get { return ((ValueElement)base["path"]); }
        }

        [ConfigurationProperty("queryParams")]
        public QueryParamCollection QueryParams
        {
            get { return ((QueryParamCollection)base["queryParams"]); }
        }
    }
}
