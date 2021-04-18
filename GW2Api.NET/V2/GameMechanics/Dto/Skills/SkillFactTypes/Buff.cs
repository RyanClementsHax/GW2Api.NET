namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    public record Buff(
        string Text,
        string Icon,

        string Status,
        string Description,
        int? ApplyCount,
        int? Duration
    ) : SkillFact(
        Text,
        Icon
    );
}
