using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwMap(
        int Id,
        WvwMapType Type,
        IDictionary<ServerColor, int> Scores,
        IDictionary<ServerColor, int> Deaths,
        IDictionary<ServerColor, int> Kills,
        IList<WvwObjective> Objectives,
        IList<WvwBonus> Bonuses
    );
}
