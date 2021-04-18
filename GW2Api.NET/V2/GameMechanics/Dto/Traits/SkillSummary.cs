using GW2Api.NET.V2.GameMechanics.Dto.Common.Facts;
using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Traits
{
    public record SkillSummary(
        int Id,
        string Name,
        string Description,
        string Icon,
        IList<Fact> Facts,
        IList<Fact> TraitedFacts
    );
}
