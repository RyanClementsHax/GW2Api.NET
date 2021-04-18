using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    [JsonDiscriminator("Distance")]
    public record DistanceFact(
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
