using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Gizmo.GizmoTypes
{
    [JsonDiscriminator("ContainerKey")]
    public record ContainerKey() : GizmoSubDetail();
}
