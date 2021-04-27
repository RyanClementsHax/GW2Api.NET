using System.Collections.Generic;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record Skirmish(
        int Id,
        IDictionary<ServerColor, int> Scores,
        IList<MapSkirmishScore> MapScores
    );
}