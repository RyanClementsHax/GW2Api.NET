using GW2Api.NET.Json.Attributes;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Minipet
{
    [JsonDiscriminator("MiniPet")]
    public record MinipetDetail(
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

        MinipetSubDetail Minipet
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
