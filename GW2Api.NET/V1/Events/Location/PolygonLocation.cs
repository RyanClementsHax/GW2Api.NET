using GW2Api.NET.Json;
using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Events.Locations
{
    [JsonDiscriminator("poly")]
    public record PolygonLocation(
        Vector3 Center,
        IReadOnlyCollection<double> ZRange,
        IReadOnlyCollection<IReadOnlyCollection<double>> Points
    ) : Location(Center);
}
