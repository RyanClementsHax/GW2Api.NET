using GW2Api.NET.V2.GameMechanics.Dto.Common.Combos;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record ComboFinisher(
        string Text,
        string Icon,
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
