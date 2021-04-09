using System;
using System.Collections.Generic;
using System.Linq;

namespace GW2Api.NET.IntegrationTests
{
    public static class LinqExt
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            var rnd = new Random();
            return source.OrderBy((item) => rnd.Next());
        }
    }
}
