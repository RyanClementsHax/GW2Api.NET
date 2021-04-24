using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace GW2Api.NET.IntegrationTests
{
    public static class TestData
    {
        public static CancellationTokenSource CreateDefaultTokenSource()
            => new(TimeSpan.FromMinutes(5));

        public static Func<CancellationTokenSource>[] DefaultCtsFactories { get; } =
                new Func<CancellationTokenSource>[] { () => null, () => CreateDefaultTokenSource() };

        public static object[] DefaultLangs { get; } =
                new[] { null, "es" }.Select(x => x is null ? null : new CultureInfo(x)).ToObjectArray();

        public static IEnumerable<object[]> DefaultTestData()
            => new List<object[]>
            {
                DefaultCtsFactories,
            }.Permute();

        public static IEnumerable<object[]> DefaultLangTestData()
            => new List<object[]>
            {
                DefaultLangs,
                DefaultCtsFactories,
            }.Permute();

        public static DateTimeOffset DefaultExpire => DateTimeOffset.Now.AddMinutes(1);

        public static CancellationToken GetTokenOrDefault(this CancellationTokenSource cts)
            => cts?.Token ?? default;
    }
}
