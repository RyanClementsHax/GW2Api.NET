using GW2Api.NET.V2.GameMechanics.Dto.Common.Facts;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Traits
{
    public record Trait(
        int Id,
        string Name,
        Uri Icon,
        string Description,
        int Specialization,
        int Tier,
        TraitSlot Slot,
        IList<Fact> Facts,
        IList<Fact> TraitedFacts,
        IList<SkillSummary> Skills
    );
}
