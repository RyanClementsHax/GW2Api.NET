using System;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record GuildSeasonInfo(
        Guid Id,
        int Wins,
        int Losses,
        int Rating
    );
}