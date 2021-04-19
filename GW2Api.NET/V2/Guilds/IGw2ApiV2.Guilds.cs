using GW2Api.NET.V2.Guilds.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<Guild> GetGuildAsync(Guid id, CancellationToken token = default);
    }
}
