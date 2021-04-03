using GW2Api.NET.V2.Tokens;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<string> CreateSubTokenAsync(DateTimeOffset expire, Permissions permissions, IEnumerable<string> urls = null, string accessToken = null, CancellationToken token = default);
    }
}
