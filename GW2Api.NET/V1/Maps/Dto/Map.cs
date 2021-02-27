using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record Map(
        string MapId,
        string MapName,
        int MinLevel,
        int MaxLevel,
        int DefaultFloor,
        string Type,
        IReadOnlyCollection<int> Floors,
        int RegionId,
        string RegionName,
        int ContinentId,
        string ContinentName,
        IReadOnlyCollection<Vector2> MapRect,
        IReadOnlyCollection<Vector2> ContinentRect
    );
}
