using GW2Api.NET.V1.Guilds.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<GuildDetails> GetGuildDetails(Guid guildId, CancellationToken token = default);
        Task<GuildDetails> GetGuildDetails(string guildName, CancellationToken token = default);
    }
}
