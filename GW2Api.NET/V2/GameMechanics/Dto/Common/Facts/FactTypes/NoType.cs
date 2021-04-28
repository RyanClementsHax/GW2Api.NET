using GW2Api.NET.Json.Attributes;
using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    [AbstractClassDefaultType]
    public record NoType(
        string Text,
        Uri Icon,
        int? RequiresTrait,
        int? Overrides
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
