using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record EmblemLayer(
        int Id,
        IList<int> Colors
    );
}
