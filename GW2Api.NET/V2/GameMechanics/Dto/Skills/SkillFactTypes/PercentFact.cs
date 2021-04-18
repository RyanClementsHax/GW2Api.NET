using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    [JsonDiscriminator("Percent")]
    public record PercentFact(
        string Text,
        string Icon,

        double Percent
    ) : SkillFact(
        Text,
        Icon
    );
}
