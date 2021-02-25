using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Tool
{
    [JsonConverter(typeof(AbstractClassConverter<ToolSubDetail>))]
    public abstract record ToolSubDetail();
}
