using GW2Api.NET.V2.GameMechanics.Dto.Professions;
using GW2Api.NET.V2.GameMechanics.Dto.Races;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Stories.Dto
{
    public record BackstoryQuestion(
        int Id,
        string Title,
        string Description,
        IList<string> Answers,
        int Order,
        IList<Race> Races,
        IList<Profession> Professions
    );
}
