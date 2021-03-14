using GW2Api.NET.Json.Attributes;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Items.Dto.ItemTypes.Gizmo
{
    [JsonDiscriminator("Gizmo")]
    public record GizmoDetail(
        int ItemId,
        string Name,
        string Description,
        int Level,
        Rarity Rarity,
        int VendorValue,
        int IconFileId,
        string IconFileSignature,
        IList<GameType> GameTypes,
        IList<ItemFlag> Flags,
        IList<Restriction> Restrictions,

        GizmoSubDetail Gizmo
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
