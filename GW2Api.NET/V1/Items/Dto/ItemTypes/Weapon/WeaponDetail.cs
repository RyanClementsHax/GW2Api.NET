using GW2Api.NET.Json;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Weapon
{
    [JsonDiscriminator("Weapon")]
    public record WeaponDetail(
        int ItemId,
        string Name,
        string Description,
        int Level,
        Rarity Rarity,
        int VendorValue,
        int IconFileId,
        string IconFileSignature,
        int DefaultSkin,
        IReadOnlyCollection<GameType> GameTypes,
        IReadOnlyCollection<Flag> Flags,
        IReadOnlyCollection<Restriction> Restrictions,

        WeaponSubDetail Weapon
    ) : ItemDetail(
        ItemId,
        Name,
        Description,
        Level,
        Rarity,
        VendorValue,
        IconFileId,
        IconFileSignature,
        DefaultSkin,
        GameTypes,
        Flags,
        Restrictions
    );
}
