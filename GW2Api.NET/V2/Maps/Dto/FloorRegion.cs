using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record FloorRegion(
        int Id,
        string Name,
        Vector2 LabelCoord,
        IList<Vector2> ContinentRect,
        IDictionary<int, Map> Maps
    );
}
