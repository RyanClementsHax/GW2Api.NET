namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record Heal(
        string Text,
        string Icon,

        int HitCount
    ) : SkillFact(
        Text,
        Icon
    );
}
