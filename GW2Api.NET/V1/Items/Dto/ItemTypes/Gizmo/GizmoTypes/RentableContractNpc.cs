using GW2Api.NET.Json.Attributes;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Gizmo.GizmoTypes
{
    [JsonDiscriminator("RentableContractNpc")]
    public record RentableContractNpc() : GizmoSubDetail();
}
