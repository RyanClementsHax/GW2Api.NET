using System.Collections.Generic;

namespace GW2Api.NET.V2.GameMechanics.Dto
{
    public record MountType(
        string Id,
        string Name,
        int DefaultSkin,
        IList<int> Skins,
        IList<Skill> Skills
    );
}
