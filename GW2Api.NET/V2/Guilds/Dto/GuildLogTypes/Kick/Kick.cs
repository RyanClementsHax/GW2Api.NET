using System;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.Kick
{
    public record Kick(
        int Id,
        DateTimeOffset Time,
        string User,

        string KickedBy
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
