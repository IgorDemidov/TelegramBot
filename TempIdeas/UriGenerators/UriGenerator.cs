using System;
using System.Web;
using System.Collections.Specialized;
using TempIdeas.ConfigMappers.Models;

namespace TempIdeas.UriGenerators
{
    public class UriGenerator: IUriGenerator
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
            NameValueCollection queryBlank = HttpUtility.ParseQueryString(string.Empty);

            foreach (QueryParamElement qp in queryParams)
            {
                queryBlank[qp.ParamName] = qp.Value;
            }

            return queryBlank.ToString();
        }
    }
}
