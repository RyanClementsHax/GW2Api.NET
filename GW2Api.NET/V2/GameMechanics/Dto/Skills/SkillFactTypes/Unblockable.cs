namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record Unblockable(
        string Text,
        string Icon,

        bool Value
    ) : SkillFact(
        Text,
        Icon
    );
}
