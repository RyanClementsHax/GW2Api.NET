using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GW2Api.NET.IntegrationTests
{
    public static class TestParamsExt
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

        public static object[] ToLangStrObjectArray(this (string, string)[] source)
            => source.Select(
                x => (
                    x.Item1 switch
                    {
                        null => null,
                        _ => new CultureInfo(x.Item1)
                    },
                    x.Item2
                )
            ).ToObjectArray();

        public static object[] ToLangStrsObjectArray(this (string, IEnumerable<string>)[] source)
            => source.Select(
                x => (
                    x.Item1 switch
                    {
                        null => null,
                        _ => new CultureInfo(x.Item1)
                    },
                    x.Item2
                )
            ).ToObjectArray();
    }
}
