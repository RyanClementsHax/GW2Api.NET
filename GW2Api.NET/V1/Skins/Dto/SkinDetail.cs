using GW2Api.NET.Json.Converters;
using GW2Api.NET.V1.Skins.Dto.SkinTypes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Skins.Dto
{
    [JsonConverter(typeof(AbstractClassConverter<SkinDetail>))]
    public abstract record SkinDetail(
        [property: JsonConverter(typeof(StringToIntConverter))] int SkinId,
        string Name,
        IList<SkinFlags> Flags,
        IList<string> Restrictions,
        string IconFileId,
        string IconFileSignature,
        string Description
    );
}
