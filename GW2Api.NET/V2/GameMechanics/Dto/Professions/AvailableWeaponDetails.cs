using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Professions
{
    public record AvailableWeaponDetails(
        IList<AvailableWeaponFlag> Flags,
        int? Specialization,
        IList<ProfessionSkill> Skills
    );
}