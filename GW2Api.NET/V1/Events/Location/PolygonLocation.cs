using GW2Api.NET.Json;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Events.Locations
{
    [JsonDiscriminator("poly")]
    public record PolygonLocation(
        IReadOnlyCollection<double> Center,
        IReadOnlyCollection<double> ZRange,
        IReadOnlyCollection<IReadOnlyCollection<double>> Points
    ) : Location(Center);
}
