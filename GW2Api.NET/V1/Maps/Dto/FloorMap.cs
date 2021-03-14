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
        IList<Vector2> MapRect,
        IList<Vector2> ContinentRect,
        IList<PointOfInterest> PointsOfInterest,
        IList<GodShrine> GodShrines,
        IList<MapTask> Tasks,
        IList<SkillChallenge> SkillChallenges,
        IList<Sector> Sectors
    );
}
