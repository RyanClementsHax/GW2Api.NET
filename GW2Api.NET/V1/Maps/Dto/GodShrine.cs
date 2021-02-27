using GW2Api.NET.V1.Files.Dto;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record GodShrine(
        int Id,
        string Name,
        string NameContested,
        Vector2 Coord,
        int PoiId,
        Icon Icon,
        Icon IconContested
    );
}
