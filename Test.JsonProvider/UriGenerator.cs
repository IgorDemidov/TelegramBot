using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.JsonProvider
{
    public class UriGenerator
    {
        public Uri Uri { get; private set; }

        public UriGenerator(UriConfig config)
        {
            UriBuilder uriBuilder = new UriBuilder
            {
                Scheme = config.Scheme.Value,
                Host = config.Host.Value,
                Path = config.Path.Value,
                Query = this.GenerateQueryString(config.QueryParams)
            };
            Uri = uriBuilder.Uri;
        }

        private string GenerateQueryString(QueryParamCollection queryParams)
        {
            NameValueCollection queryBlank = System.Web.HttpUtility.ParseQueryString(string.Empty);

            foreach (QueryParamElement qp in queryParams)
            {
                queryBlank[qp.ParamName] = qp.Value;
            }

            return queryBlank.ToString();
        }
    }
}
