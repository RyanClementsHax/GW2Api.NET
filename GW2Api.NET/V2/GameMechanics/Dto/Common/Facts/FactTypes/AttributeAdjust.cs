using GW2Api.NET.V2.Items.Dto.Common;
using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record AttributeAdjust(
        string Text,
        Uri Icon,
        int? RequiresTrait,
        int? Overrides,

        int Value,
        AttributeType Target
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
