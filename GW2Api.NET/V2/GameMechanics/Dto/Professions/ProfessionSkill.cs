using GW2Api.NET.V2.Items.Dto.ItemTypes.Weapon;

namespace GW2Api.NET.V2.GameMechanics.Dto.Professions
{
    public record ProfessionSkill(
        int Id,
        SkillSlot Slot,
        WeaponType? Offhand,
        Attunement? Attunement,
        Profession? Source
    );
}