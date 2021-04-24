using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record Map(
        int Id,
        string Name,
        int MinLevel,
        int MaxLevel,
        int DefaultFloor,
        IList<int> Floors,
        int RegionId,
        string RegionName,
        int ContinentId,
        string ContinentName,
        IList<Vector2> MapRect,
        IList<Vector2> ContinentRect
    );
}
