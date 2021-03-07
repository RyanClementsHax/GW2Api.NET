using System;
using System.Collections.Generic;
using System.Threading;

namespace GW2Api.NET.IntegrationTests
{
    public static class TestData
    {
        public static CancellationTokenSource CreateDefaultTokenSource()
            => new(TimeSpan.FromMinutes(1));

        public static IEnumerable<object[]> CancellationTokenSourceTestData()
            => new List<object[]>
            {
                DefaultCtsFactories,
            }.Permute();

        public static Func<CancellationTokenSource>[] DefaultCtsFactories { get; } =
                new Func<CancellationTokenSource>[] { () => null, () => CreateDefaultTokenSource() };
    }
}
