using GW2Api.NET.Json.Attributes;
using GW2Api.NET.Json.Converters;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        IReadOnlyCollection<GameType> GameTypes,
        IReadOnlyCollection<ItemFlag> Flags,
        IReadOnlyCollection<Restriction> Restrictions,

        WeaponSubDetail Weapon,
        [property: JsonConverter(typeof(StringToIntConverter))] int DefaultSkin
    ) : ItemDetail(
        ItemId,
        Name,
        Description,
        Level,
        Rarity,
        VendorValue,
        IconFileId,
        IconFileSignature,
        GameTypes,
        Flags,
        Restrictions
    );
}
