using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record Emblem(
        EmblemLayer Background,
        EmblemLayer Foreground,
        IList<GuildFlag> Flags
    );
}