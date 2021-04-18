using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V2.GameMechanics.Dto.Skills
{
    [JsonConverter(typeof(AbstractClassConverter<SkillFact>))]
    public abstract record SkillFact(
        string Text,
        string Icon
    );
}