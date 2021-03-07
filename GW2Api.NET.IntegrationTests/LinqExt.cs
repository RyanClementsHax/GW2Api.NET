using System;
using System.Collections.Generic;
using System.Linq;

namespace GW2Api.NET.IntegrationTests
{
    public static class LinqExt
    {
        public static IEnumerable<object[]> Permute(this IEnumerable<object> source)
        {
            IEnumerable<object[]> emptyProduct = new[] { Array.Empty<object>() };
            return source
                .Select(x =>
                    x is object[] or Func<object>[]
                        ? (object[])x
                        : new[] { x }
                )
                .AsEnumerable()
                .Aggregate(
                    emptyProduct,
                    (accumulator, sequence) =>
                        from accseq in accumulator
                        from item in sequence
                        select accseq.Concat(new[] { item }).ToArray()
                );
        }

        public static object[] ToObjectArray<T>(this IEnumerable<T> source)
            => source.Select(x => (object)x).ToArray();
    }
}
