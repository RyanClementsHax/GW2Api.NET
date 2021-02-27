using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record PointOfInterest(
        int PoiId,
        string Name,
        PointOfInterestType Type,
        int Floor,
        Vector2 Coord
    );
}
