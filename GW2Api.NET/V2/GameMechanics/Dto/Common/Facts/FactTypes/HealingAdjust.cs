namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record HealingAdjust(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        int HealAdjust
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
