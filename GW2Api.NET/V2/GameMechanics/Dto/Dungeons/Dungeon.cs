using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Dungeons
{
    public record Dungeon(
        string Id,
        IList<DungeonPath> Paths
    );
}
