using System;
using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record GodShrine(
        int Id,
        string Name,
        string NameContested,
        Vector2 Coord,
        int PoiId,
        Uri Icon,
        string IconContested
    );
}
