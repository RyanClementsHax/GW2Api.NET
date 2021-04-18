using GW2Api.NET.V2.GameMechanics.Dto.Common.Facts;
using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Traits
{
    public record Trait(
        int Id,
        string Name,
        string Icon,
        string Description,
        int Specialization,
        int Tier,
        TraitSlot Slot,
        IList<Fact> Facts,
        IList<Fact> TraitedFacts,
        IList<SkillSummary> Skills
    );
}
