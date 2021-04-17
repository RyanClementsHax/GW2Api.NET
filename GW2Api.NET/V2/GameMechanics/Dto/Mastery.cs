using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto
{
    public record Mastery(
        int Id,
        string Name,
        string Requirement,
        int Order,
        string Background,
        string Region,
        IList<MasteryLevel> Levels
    );
}
