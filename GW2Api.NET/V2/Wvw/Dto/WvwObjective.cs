using System;
using System.Numerics;

namespace GW2Api.NET.V2.Wvw.Dto
{
    public record WvwObjective(
        string Id,
        string Name,
        WvwObjectiveType Type,
        int SectorId,
        int MapId,
        WvwMapType MapType,
        Vector3 Coord,
        Vector2 LabelCoord,
        Uri Marker,
        string ChatLink
    );
}
