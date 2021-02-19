using System.Collections.Generic;

namespace GW2Api.NET.V1.Guilds
{
    public record Emblem(
        int BackgroundId,
        int ForegroundId,
        IReadOnlyCollection<EmblemFlag> Flags,
        int BackgroundColorId,
        int ForegroundPrimaryColorId,
        int ForegroundSecondaryColorId
    );
}
