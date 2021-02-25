using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Container.ContainerTypes
{
    [JsonDiscriminator("Default")]
    public record Default() : ContainerSubDetail();
}
