namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record Time(
        string Text,
        string Icon,

        int Duration
    ) : SkillFact(
        Text,
        Icon
    );
}
