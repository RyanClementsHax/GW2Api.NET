namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record Radius(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        int Distance
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
