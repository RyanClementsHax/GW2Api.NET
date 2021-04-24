using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record PointOfInterest(
        int Id,
        PointOfInterestType Type,
        string Name,
        int Floor,
        Vector2 Coord,
        string ChatLink
    );
}
