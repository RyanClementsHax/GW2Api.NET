namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record Heal(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        int HitCount
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
