using System.Numerics;

namespace GW2Api.NET.V1.Maps.Dto
{
    public record SkillChallenge(
        Vector2 Coord,
        int Expac,
        int Idx
    );
}
