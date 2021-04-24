using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record MapTask(
        int Id,
        string Objective,
        int Level,
        Vector2 Coord,
        IList<Vector2> Bounds
    );
}
