using GW2Api.NET.V2.GameMechanics.Dto.Common.Combos;
using System;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record ComboFinisher(
        string Text,
        Uri Icon,
        int? RequiresTrait,
        int? Overrides,

        int Percent,
        FinisherType FinisherType
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
