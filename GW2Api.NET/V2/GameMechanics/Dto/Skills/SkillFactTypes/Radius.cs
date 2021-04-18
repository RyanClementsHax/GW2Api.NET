namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record Radius(
        string Text,
        string Icon,

        int Distance
    ) : SkillFact(
        Text,
        Icon
    );
}
