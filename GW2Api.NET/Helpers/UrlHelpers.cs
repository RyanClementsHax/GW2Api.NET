﻿using System.Collections.Generic;
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
                    seed.Add(current.Key, current.Value);
                    return seed;
                }
            ));
            return $"{url}{queryStr}";
        }
    }
}