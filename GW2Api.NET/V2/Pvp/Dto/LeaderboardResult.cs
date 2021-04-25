using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record LeaderboardResult(
        string Name,
        int Rank,
        Guid? Id,
        string Team,
        int? TeamId,
        DateTimeOffset Date,
        IList<LeaderboardResultScore> Scores
    );
}
