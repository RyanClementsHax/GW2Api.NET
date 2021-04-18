namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record Damage(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        int HitCount,
        double DmgMultiplier
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
