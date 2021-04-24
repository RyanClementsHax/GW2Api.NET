using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record Sector(
        int Id,
        string Name,
        int Level,
        Vector2 Coord,
        IList<Vector2> Bounds,
        string ChatLink
    );
}
