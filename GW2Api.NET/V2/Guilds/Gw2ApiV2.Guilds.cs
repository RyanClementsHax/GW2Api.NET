using GW2Api.NET.V2.Guilds.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<Guild> GetGuildAsync(Guid id, CancellationToken token = default)
            => GetAsync<Guild>($"guild/{id}", token);
    }
}
