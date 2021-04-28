using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.Skins.SkinTypes.Armor
{
    public record Armor(
        int Id,
        string Name,
        SkinType Type,
        IList<SkinFlag> Flags,
        IList<Restriction> Restrictions,
        Uri Icon,
        Rarity Rarity,
        string Description,

        ArmorDetails Details
    ) : Skin(
        Id,
        Name,
        Type,
        Flags,
        Restrictions,
        Icon,
        Rarity,
        Description
    );
}
