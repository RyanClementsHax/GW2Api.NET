using GW2Api.NET.Json.Attributes;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Skins.Dto.SkinTypes.Weapon
{
    [JsonDiscriminator("Weapon")]
    public record WeaponSkinDetail(
        int SkinId,
        string Name,
        IList<SkinFlags> Flags,
        IList<string> Restrictions,
        string IconFileId,
        string IconFileSignature,
        string Description,

        WeaponSkinSubDetail Weapon
    ) : SkinDetail(
        SkinId,
        Name,
        Flags,
        Restrictions,
        IconFileId,
        IconFileSignature,
        Description
    );
}
