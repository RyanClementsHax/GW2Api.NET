namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record Recharge(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        double Value
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
