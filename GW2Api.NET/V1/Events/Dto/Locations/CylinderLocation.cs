using GW2Api.NET.Json.Attributes;
using System.Numerics;

namespace GW2Api.NET.V1.Events.Dto.Locations
{
    [JsonDiscriminator("cylinder")]
    public record CylinderLocation(
        Vector3 Center,
        double Height,
        double Radius,
        double Rotation
    ) : Location(Center);
}
