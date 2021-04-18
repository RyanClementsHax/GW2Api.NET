using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    [AbstractClassDefaultType]
    public record NoType(
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
