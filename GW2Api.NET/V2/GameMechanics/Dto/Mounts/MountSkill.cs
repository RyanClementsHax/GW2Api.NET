using GW2Api.NET.V2.GameMechanics.Dto.Skills;

namespace GW2Api.NET.V2.GameMechanics.Dto.Mounts
{
    public record MountSkill(
        int Id,
        SkillSlot Slot
    );
}