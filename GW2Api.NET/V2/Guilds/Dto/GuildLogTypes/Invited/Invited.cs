using System;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.Invited
{
    public record Invited(
        int Id,
        DateTimeOffset Time,
        string User,

        string InvitedBy
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
