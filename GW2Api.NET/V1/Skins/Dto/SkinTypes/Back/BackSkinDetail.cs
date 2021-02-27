using GW2Api.NET.Json.Attributes;
using System.Collections.Generic;

namespace GW2Api.NET.V1.Skins.Dto.SkinTypes.Back
{
    [JsonDiscriminator("Back")]
    public record BackSkinDetail(
        int SkinId,
        string Name,
        IReadOnlyCollection<SkinFlags> Flags,
        IReadOnlyCollection<string> Restrictions,
        string IconFileId,
        string IconFileSignature,
        string Description
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
