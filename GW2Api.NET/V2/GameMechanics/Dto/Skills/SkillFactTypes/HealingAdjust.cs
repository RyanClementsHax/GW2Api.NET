namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record HealingAdjust(
        string Text,
        string Icon,

        int HealAdjust
    ) : SkillFact(
        Text,
        Icon
    );
}
