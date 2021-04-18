namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record Damage(
        string Text,
        string Icon,

        int HitCount,
        double DmgMultiplier
    ) : SkillFact(
        Text,
        Icon
    );
}
