using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record MapFloor(
        Vector2 TextureDims,
        IReadOnlyCollection<Vector2> ClampedView,
        IReadOnlyDictionary<string, Region> Regions
    );
}
