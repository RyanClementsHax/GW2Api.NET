using GW2Api.NET.V2.Items.Dto.ItemTypes.Weapon;
using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Professions
{
    public record ProfessionDetails(
        string Id,
        string Name,
        string Icon,
        string IconBig,
        IList<int> Specializations,
        IList<Training> Training,
        IDictionary<WeaponType, AvailableWeaponDetails> Weapons,
        IList<ProfessionFlag> Flags,
        IList<ProfessionSkillSummary> Skills
    );
}
