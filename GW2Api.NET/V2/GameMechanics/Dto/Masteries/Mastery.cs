using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Masteries
{
    public record Mastery(
        int Id,
        string Name,
        string Requirement,
        int Order,
        string Background,
        Region Region,
        IList<MasteryLevel> Levels
    );
}
