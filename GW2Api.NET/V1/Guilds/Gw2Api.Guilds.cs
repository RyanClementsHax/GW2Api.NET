using GW2Api.NET.V1.Guilds;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _guildResource = "guild_details.json";

        public Task<GuildDetails> GetGuildDetails(Guid guildId, CancellationToken token = default)
            => GetAsync<GuildDetails>(
                _guildResource,
                new Dictionary<string, string>
                {
                    { "guild_id", guildId.ToString() }
                },
                token
            );

        public Task<GuildDetails> GetGuildDetails(string guildName, CancellationToken token = default)
            => GetAsync<GuildDetails>(
                _guildResource,
                new Dictionary<string, string>
                {
                    { "guild_name", guildName }
                },
                token
            );
    }
}
