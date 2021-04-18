namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record NoData(
        string Text,
        string Icon
    ) : SkillFact(
        Text,
        Icon
    );
}
