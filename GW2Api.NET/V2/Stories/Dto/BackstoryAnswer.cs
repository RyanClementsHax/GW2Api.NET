using GW2Api.NET.V2.GameMechanics.Dto.Professions;
using GW2Api.NET.V2.GameMechanics.Dto.Races;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Stories.Dto
{
    public record BackstoryAnswer(
        string Id,
        string Title,
        string Description,
        string Journal,
        int Question,
        IList<Profession> Professions,
        IList<Race> Races
    );
}
