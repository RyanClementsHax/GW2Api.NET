using System;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record GuildMember(
        string Name,
        string Rank,
        DateTimeOffset Joined
    );
}
