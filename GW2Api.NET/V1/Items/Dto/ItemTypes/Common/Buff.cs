using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Common
{
    public record Buff(
        [property: JsonConverter(typeof(StringToIntConverter))] int SkillId,
        string Description
    );
}
