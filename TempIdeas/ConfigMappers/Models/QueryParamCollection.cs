using System.Configuration;

namespace TempIdeas.ConfigMappers.Models
{
    [ConfigurationCollection(typeof(QueryParamElement))]
    public class QueryParamCollection : ConfigurationElementCollection
    {
        public QueryParamElement this[string name]
        {
            get { return (QueryParamElement)base.BaseGet(name); }
        }

        public QueryParamElement this[int index]
        {
            get { return (QueryParamElement)base.BaseGet(index); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new QueryParamElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((QueryParamElement)element).Name;
        }
    }
}
