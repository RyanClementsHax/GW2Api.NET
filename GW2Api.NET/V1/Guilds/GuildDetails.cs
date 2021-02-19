using System;

namespace GW2Api.NET.V1.Guilds
{
    public record GuildDetails(
        Guid GuildId,
        string GuildName,
        string Tag,
        Emblem Emblem
    );
}
