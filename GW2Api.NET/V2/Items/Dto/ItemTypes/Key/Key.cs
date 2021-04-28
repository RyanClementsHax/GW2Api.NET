using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.Key
{
    public record Key(
        int Id,
        string ChatLink,
        string Name,
        Uri Icon,
        string Description,
        Rarity Rarity,
        int Level,
        int VendorValue,
        int? DefaultSkin,
        IList<ItemFlag> Flags,
        IList<GameType> GameTypes,
        IList<Restriction> Restrictions,
        IList<UpgradeInfo> UpgradesInto,
        IList<UpgradeInfo> UpgradesFrom
    ) : Item(
        Id,
        ChatLink,
        Name,
        Icon,
        Description,
        Rarity,
        Level,
        VendorValue,
        DefaultSkin,
        Flags,
        GameTypes,
        Restrictions,
        UpgradesInto,
        UpgradesFrom
    );
}
