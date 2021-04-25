using System;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record LeaderboardResultScore(
        Guid Id,
        int Value
    );
}