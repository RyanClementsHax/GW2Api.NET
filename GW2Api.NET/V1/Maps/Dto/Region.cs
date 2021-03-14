using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record Region(
        string RegionId,
        string Name,
        Vector2 LabelCoord,
        IList<Vector2> ContinentRect,
        IDictionary<string, FloorMap> Maps
    );
}
