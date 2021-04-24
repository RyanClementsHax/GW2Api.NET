using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record Continent(
        int Id,
        string Name,
        Vector2 ContinentDims,
        int MinZoom,
        int MaxZoom,
        IList<int> Floors
    );
}
