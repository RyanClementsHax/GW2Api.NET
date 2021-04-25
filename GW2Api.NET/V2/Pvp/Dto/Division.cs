using System.Collections.Generic;

namespace GW2Api.NET.V2.Pvp.Dto
{
    public record Division(
        string Name,
        IList<DivisionFlag> Flags,
        string LargeIcon,
        string SmallIcon,
        string PipIcon,
        IList<DivisionTier> Tiers
    );
}