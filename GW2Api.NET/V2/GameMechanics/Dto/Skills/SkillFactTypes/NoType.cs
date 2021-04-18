using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V2.GameMechanics.Dto.Skills.SkillFactTypes
{
    [AbstractClassDefaultType]
    public record NoType(
        string Text,
        string Icon
    ) : SkillFact(
        Text,
        Icon
    );
}
