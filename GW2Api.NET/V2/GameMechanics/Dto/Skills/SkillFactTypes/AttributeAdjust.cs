using GW2Api.NET.V2.Items.Dto.Common;

namespace GW2Api.NET.V2.GameMechanics.Dto.Skills
{
    public record AttributeAdjust(
        string Text,
        string Icon,

        int Value,
        AttributeType Target
    ) : SkillFact(
        Text,
        Icon
    );
}
