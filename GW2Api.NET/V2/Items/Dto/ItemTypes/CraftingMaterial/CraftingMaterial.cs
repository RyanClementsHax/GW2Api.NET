using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2Api.NET.V2.Items.Dto.ItemTypes.CraftingMaterial
{
    public record CraftingMaterial(
        int Id,
        string ChatLink,
        string Name,
        string Icon,
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
