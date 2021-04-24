using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record GodShrine(
        int Id,
        string Name,
        string NameContested,
        Vector2 Coord,
        int PoiId,
        string Icon,
        string IconContested
    );
}
