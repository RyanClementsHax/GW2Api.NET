using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Tokens;
using GW2Api.NET.V2.Tokens.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public async Task<string> CreateSubTokenAsync(DateTimeOffset expire, Permissions permissions, IEnumerable<string> urls = null, string accessToken = null, CancellationToken token = default)
            => (await GetWithAuthAsync<CreateSubTokenResponse>(
                "createsubtoken",
                new Dictionary<string, string>()
                    .AddIfAny("permissions", permissions)
                    .AddIfAny("urls", urls),
                accessToken,
                token
            )).Subtoken;
    }
}
