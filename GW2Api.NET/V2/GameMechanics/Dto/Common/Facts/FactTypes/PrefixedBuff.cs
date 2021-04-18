namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record PrefixedBuff(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        string Status,
        string Description,
        int? ApplyCount,
        int? Duration,
        FactPrefix Prefix
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
