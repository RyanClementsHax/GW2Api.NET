using System.Collections.Generic;

namespace GW2Api.NET.V2.Characters.Dto
{
    public record Sab(
        IList<SabZone> Zones,
        IList<SabUnlock> Unlocks,
        IList<SabSong> Songs
    );
}
