using System;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.Joined
{
    public record Joined(
        int Id,
        DateTimeOffset Time,
        string User
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
