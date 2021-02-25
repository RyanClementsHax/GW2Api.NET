using GW2Api.NET.Json.Converters;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Gizmo
{
    [JsonConverter(typeof(AbstractClassConverter<GizmoSubDetail>))]
    public record GizmoSubDetail();
}
