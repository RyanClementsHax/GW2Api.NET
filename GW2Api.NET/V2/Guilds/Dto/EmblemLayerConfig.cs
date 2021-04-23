using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record EmblemLayerConfig(
        int Id,
        IList<int> Colors
    );
}
