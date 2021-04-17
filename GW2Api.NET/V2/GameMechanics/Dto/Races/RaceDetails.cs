using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Races
{
    public record RaceDetails(
        string Id,
        string Name,
        IList<int> Skills
    );
}
