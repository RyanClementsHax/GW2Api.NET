using GW2Api.NET.Json;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Events.Locations
{
    [JsonDiscriminator("cylinder")]
    public record CylinderLocation(
        IReadOnlyCollection<double> Center,
        double Height,
        double Radius,
        double Rotation
    ) : Location(Center);
}
