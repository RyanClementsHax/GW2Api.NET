using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    [JsonDiscriminator("Duration")]
    public record DurationFact(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        int Duration
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
