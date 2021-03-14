using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record Sector(
        int SectorId,
        string Name,
        int Level,
        Vector2 Coord,
        IList<Vector2> Bounds
    );
}
