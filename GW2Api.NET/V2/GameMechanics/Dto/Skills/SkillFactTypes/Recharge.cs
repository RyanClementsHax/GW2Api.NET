namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record Recharge(
        string Text,
        string Icon,

        double Value
    ) : SkillFact(
        Text,
        Icon
    );
}
