using System;
using System.Threading;

namespace GW2Api.NET.IntegrationTests
{
    public static class TestData
    {
        public static CancellationTokenSource CreateDefaultTokenSource()
            => new CancellationTokenSource(TimeSpan.FromSeconds(5));
    }
}
