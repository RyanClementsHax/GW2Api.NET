using System;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.Treasury
{
    public record Treasury(
        int Id,
        DateTimeOffset Time,
        string User,

        int ItemId,
        int Count
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
