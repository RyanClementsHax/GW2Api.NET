namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record Unblockable(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        bool Value
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
