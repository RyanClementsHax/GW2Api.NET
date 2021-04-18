namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record NoData(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
