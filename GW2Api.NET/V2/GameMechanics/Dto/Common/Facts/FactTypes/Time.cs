using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record Time(
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
