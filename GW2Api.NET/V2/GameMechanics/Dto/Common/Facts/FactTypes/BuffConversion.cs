using GW2Api.NET.V2.Items.Dto.Common;

namespace GW2Api.NET.V2.GameMechanics.Dto.Common.Facts.FactTypes
{
    public record BuffConversion(
        string Text,
        string Icon,
        int? RequiresTrait,
        int? Overrides,

        double Percent,
        AttributeType Source,
        AttributeType Target
    ) : Fact(
        Text,
        Icon,
        RequiresTrait,
        Overrides
    );
}
