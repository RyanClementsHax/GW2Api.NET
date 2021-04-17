using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto.Mounts
{
    public record MountType(
        string Id,
        string Name,
        int DefaultSkin,
        IList<int> Skins,
        IList<MountSkill> Skills
    );
}
