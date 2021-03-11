using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace GW2Api.NET.Helpers
{
    internal static class UrlHelpers
    {
        public static string AddParams(this string url, IDictionary<string, string> paramsMap)
        {
            var queryStr = HttpUtility.ParseQueryString(string.Empty);
            queryStr.Add(paramsMap.Aggregate(new NameValueCollection(),
                (seed, current) =>
                {
                    if (current.Value is not null)
                    {
                        seed.Add(current.Key, current.Value);
                    }
                    return seed;
                }
            ));
            return queryStr.Count > 0
                ? $"{url}?{queryStr}"
                : url;
        }

        public static string ToUrlParam(this IEnumerable<int> source)
            => string.Join(",", source.Select(x => x.ToString()));

        public static string ToUrlParam(this IEnumerable<Guid> source)
            => string.Join(",", source.Select(x => x.ToString().ToUpper()));
    }
}
