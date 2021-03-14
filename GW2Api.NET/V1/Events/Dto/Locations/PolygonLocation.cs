using GW2Api.NET.Json.Attributes;
using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Events.Dto.Locations
{
    [JsonDiscriminator("poly")]
    public record PolygonLocation(
        Vector3 Center,
        Vector2 ZRange,
        IList<Vector2> Points
    ) : Location(Center);
}
