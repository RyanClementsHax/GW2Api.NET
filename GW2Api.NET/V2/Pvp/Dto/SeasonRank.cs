using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record SeasonRank(
        string Name,
        string Description,
        string Icon,
        Uri Overlay,
        Uri OverlaySmall,
        IList<RankTier> Tiers
    );
}
