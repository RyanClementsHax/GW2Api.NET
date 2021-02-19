using System;

namespace GW2Api.NET.V1.Guilds.Dto
{
    public record GuildDetails(
        Guid GuildId,
        string GuildName,
        string Tag,
        Emblem Emblem
    );
}
