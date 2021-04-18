using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Legends
{
    public record Legend(
        string Id,
        int Swap,
        int Heal,
        int Elite,
        IList<int> Utilities
    );
}
