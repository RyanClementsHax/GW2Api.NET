using GW2Api.NET.Json.Attributes;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Skins.Dto.SkinTypes.Armor
{
    [JsonDiscriminator("Armor")]
    public record ArmorSkinDetail(
        int SkinId,
        string Name,
        IReadOnlyCollection<SkinFlags> Flags,
        IReadOnlyCollection<string> Restrictions,
        string IconFileId,
        string IconFileSignature,
        string Description,

        ArmorSkinSubDetail Armor
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
