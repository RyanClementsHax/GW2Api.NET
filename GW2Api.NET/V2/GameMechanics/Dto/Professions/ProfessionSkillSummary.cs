using GW2Api.NET.V2.GameMechanics.Dto.Skills;

namespace GW2Api.NET.V2.GameMechanics.Dto.Professions
{
    public record ProfessionSkillSummary(
        int Id,
        SkillSlot Slot,
        SkillSlotType Type,
        Attunement? Attunement,
        Profession? Source
    );
}
