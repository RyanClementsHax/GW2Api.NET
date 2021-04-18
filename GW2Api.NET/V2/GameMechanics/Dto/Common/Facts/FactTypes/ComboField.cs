using GW2Api.NET.V2.GameMechanics.Dto.Common.Combos;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record ComboField(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        FieldType FieldType
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
