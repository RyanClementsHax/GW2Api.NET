using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record Region(
        string RegionId,
        string Name,
        Vector2 LabelCoord,
        IReadOnlyCollection<Vector2> ContinentRect,
        IReadOnlyDictionary<string, FloorMap> Maps
    );
}
