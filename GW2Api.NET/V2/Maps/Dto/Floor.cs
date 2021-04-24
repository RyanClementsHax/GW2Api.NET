using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record Floor(
        int Id,
        Vector2 TextureDims,
        IList<Vector2> ClampedView,
        IDictionary<int, MapRegion> Regions
    );
}
