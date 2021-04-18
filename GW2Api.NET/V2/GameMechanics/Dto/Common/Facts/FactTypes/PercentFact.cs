using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    [JsonDiscriminator("Percent")]
    public record PercentFact(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        double Percent
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
