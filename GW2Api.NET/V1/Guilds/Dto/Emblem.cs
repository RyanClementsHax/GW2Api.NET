using System.Collections.Generic;

namespace GW2Api.NET.V1.Guilds.Dto
{
    public record Emblem(
        int BackgroundId,
        int ForegroundId,
        IList<EmblemFlag> Flags,
        int BackgroundColorId,
        int ForegroundPrimaryColorId,
        int ForegroundSecondaryColorId
    );
}
