using GW2Api.NET.Json.Attributes;
using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    [JsonDiscriminator("Percent")]
    public record PercentFact(
        string Text,
        Uri Icon,
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
