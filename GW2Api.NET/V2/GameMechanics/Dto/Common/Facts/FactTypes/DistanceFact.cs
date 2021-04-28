using GW2Api.NET.Json.Attributes;
using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    [JsonDiscriminator("Distance")]
    public record DistanceFact(
        string Text,
        Uri Icon,
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
