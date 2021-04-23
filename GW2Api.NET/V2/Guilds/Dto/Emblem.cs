using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record Emblem(
        EmblemLayerConfig Background,
        EmblemLayerConfig Foreground,
        IList<GuildFlag> Flags
    );
}