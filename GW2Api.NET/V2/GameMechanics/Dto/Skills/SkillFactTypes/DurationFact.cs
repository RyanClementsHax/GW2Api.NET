using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    [JsonDiscriminator("Duration")]
    public record DurationFact(
        string Text,
        string Icon,

        int Duration
    ) : SkillFact(
        Text,
        Icon
    );
}
