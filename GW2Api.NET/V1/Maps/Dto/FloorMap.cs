using System.Collections.Generic;
using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record FloorMap(
        string MapId,
        string Name,
        int MinLevel,
        int MaxLevel,
        int DefaultFloor,
        Vector2 LabelCoord,
        IReadOnlyCollection<Vector2> MapRect,
        IReadOnlyCollection<Vector2> ContinentRect,
        IReadOnlyCollection<PointOfInterest> PointsOfInterest,
        IReadOnlyCollection<GodShrine> GodShrines,
        IReadOnlyCollection<MapTask> Tasks,
        IReadOnlyCollection<SkillChallenge> SkillChallenges,
        IReadOnlyCollection<Sector> Sectors
    );
}
