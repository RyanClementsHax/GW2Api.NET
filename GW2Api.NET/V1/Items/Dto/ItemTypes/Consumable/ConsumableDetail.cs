using GW2Api.NET.Json;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable
{
    [JsonDiscriminator("Consumable")]
    public record ConsumableDetail(
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

        object Consumable
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
