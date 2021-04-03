using GW2Api.NET.V2.Characters.Dto;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record PvpStats(
        int PvpRank,
        int PvpRankPoints,
        int PvpRankRollovers,
        WinLossStats Aggregate,
        IDictionary<Profession, WinLossStats> Professions,
        IDictionary<Ladder, WinLossStats> Ladders
    );
}
