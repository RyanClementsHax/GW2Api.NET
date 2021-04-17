using GW2Api.NET.V2.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GW2Api.NET.Helpers
{
    internal static class UrlHelpers
    {
        internal static string AddParams(this string url, IDictionary<string, string> paramMap)
        {
            var queryStr = HttpUtility.ParseQueryString(string.Empty);
            queryStr.Add(paramMap.Aggregate(new NameValueCollection(),
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

        internal static string ToUrlParam(this IEnumerable<string> source)
            => string.Join(",", source);

        internal static string ToUrlParam(this IEnumerable<int> source)
            => string.Join(",", source.Select(x => x.ToString()));

        internal static string ToUrlParam(this Guid source)
            => source.ToString().ToUpper();

        internal static string ToUrlParam(this IEnumerable<Guid> source)
            => string.Join(",", source.Select(x => x.ToUrlParam()));

        internal static string ToUrlParam(this Permissions permissions)
            => permissions.ToList().Select(x => x.ToString().ToLower()).ToUrlParam();

        internal static string ToUrlParam(this CultureInfo lang)
            => lang?.TwoLetterISOLanguageName;
    }
}
