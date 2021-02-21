using GW2Api.NET.V1.Guilds.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<GuildDetail> GetGuildDetail(Guid guildId, CancellationToken token = default);
        Task<GuildDetail> GetGuildDetail(string guildName, CancellationToken token = default);
    }
}
