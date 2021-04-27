using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwScore(
        string Id,
        IDictionary<ServerColor, int> Scores,
        IDictionary<ServerColor, int> VictoryPoints,
        IList<Skirmish> Skirmishes,
        IList<WvwOverallMapScore> Maps
    );
}
