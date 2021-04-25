using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record PvpSeason(
        Guid Id,
        string Name,
        DateTimeOffset Start,
        DateTimeOffset End,
        bool Active,
        IList<Division> Divisions,
        IList<SeasonRank> Ranks,
        IDictionary<LeaderboardType, Leaderboard> Leaderboards
    );
}
