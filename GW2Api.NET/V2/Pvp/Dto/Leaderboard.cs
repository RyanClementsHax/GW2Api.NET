using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record Leaderboard(
        LeaderboardSettings Settings,
        IList<Scoring> Scorings
    );
}