using GW2Api.NET.V2.Items.Dto.Common;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record AttributeAdjust(
        string Text,
        string Icon,
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
