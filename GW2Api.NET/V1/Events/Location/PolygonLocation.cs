using GW2Api.NET.Json;
using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Events.Locations
{
    [JsonDiscriminator("poly")]
    public record PolygonLocation(
        Vector3 Center,
        Vector2 ZRange,
        IReadOnlyCollection<Vector2> Points
    ) : Location(Center);
}
