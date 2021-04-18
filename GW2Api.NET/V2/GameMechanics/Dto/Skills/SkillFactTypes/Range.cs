namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record Range(
        string Text,
        string Icon,

        int Value
    ) : SkillFact(
        Text,
        Icon
    );
}
