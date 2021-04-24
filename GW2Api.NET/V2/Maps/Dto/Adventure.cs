using System;
using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record Adventure(
        Guid Id,
        string Name,
        string Description,
        Vector2 Coord
    );
}
