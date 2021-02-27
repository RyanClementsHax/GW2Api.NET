using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record MapTask(
        int TaskId,
        string Objective,
        int Level,
        Vector2 Coord,
        IReadOnlyCollection<Vector2> Bounds
    );
}
