using System;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.Stash
{
    public record Stash(
        int Id,
        DateTimeOffset Time,
        string User,

        StashOperation Operation,
        int ItemId,
        int Count,
        int Coins
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
