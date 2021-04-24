using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Titles
{
    public record Title(
        int Id,
        string Name,
        int? Achievement,
        IList<int> Achievements,
        int? ApRequired
    );
}
