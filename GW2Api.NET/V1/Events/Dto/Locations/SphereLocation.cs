using GW2Api.NET.Json.Attributes;
using System.Numerics;

namespace GW2Api.NET.V1.Events.Dto.Locations
{
    [JsonDiscriminator("sphere")]
    public record SphereLocation(
        Vector3 Center,
        double Radius,
        double Rotation
    ) : Location(Center);
}
