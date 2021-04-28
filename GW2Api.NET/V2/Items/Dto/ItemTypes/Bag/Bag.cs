using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.Bag
{
    public record Bag(
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
        IList<UpgradeInfo> UpgradesFrom,

        BagDetails Details
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
