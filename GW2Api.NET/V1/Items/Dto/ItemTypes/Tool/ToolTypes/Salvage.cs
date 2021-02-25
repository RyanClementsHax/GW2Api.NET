using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Tool.ToolTypes
{
    [JsonDiscriminator("Salvage")]
    public record Salvage() : ToolSubDetail();
}
