using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record PvpRank(
        int Id,
        int FinisherId,
        string Name,
        string Icon,
        int MinRank,
        int MaxRank,
        IList<PvpRankLevel> Levels
    );
}
