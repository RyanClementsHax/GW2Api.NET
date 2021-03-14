using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record Continent(
        string ContinentId,
        string Name,
        Vector2 ContinentDims,
        int MinZoom,
        int MaxZoom,
        IList<int> Floors
    );
}
