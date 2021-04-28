using GW2Api.NET.Json.Attributes;
using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    [JsonDiscriminator("Duration")]
    public record DurationFact(
        string Text,
        Uri Icon,
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
