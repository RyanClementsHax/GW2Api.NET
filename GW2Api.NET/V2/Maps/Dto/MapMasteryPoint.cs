using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record MapMasteryPoint(
        int Id,
        Region Region,
        Vector2 Coord
    );
}
