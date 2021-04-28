using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record Number(
        string Text,
        Uri Icon,
        int? RequiresTrait,
        int? Overrides,

        int Value
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
