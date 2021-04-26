using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record GuildRank(
        string Id,
        int Order,
        IList<string> Permissions,
        string Icon
    );
}
