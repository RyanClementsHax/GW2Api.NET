using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GW2Api.NET.V2.Maps.Dto
{
    public record Map(
        int Id,
        string Name,
        int MinLevel,
        int MaxLevel,
        int DefaultFloor,
        Vector2 LabelCoord,
        IList<Vector2> MapRect,
        IList<Vector2> ContinentRect,
        IDictionary<int, PointOfInterest> PointsOfInterest,
        IDictionary<int, MapTask> Tasks,
        IList<SkillChallenge> SkillChallenges,
        IDictionary<int, Sector> Sectors,
        IList<MapMasteryPoint> MasteryPoints,
        IList<GodShrine> GodShrines,
        IList<Adventure> Adventures
    );
}
