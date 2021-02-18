using GW2Api.NET.Json;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Events.Locations
{
    [JsonDiscriminator("sphere")]
    public record SphereLocation(
        IReadOnlyCollection<double> Center,
        double Radius,
        double Rotation
    ) : Location(Center);
}
