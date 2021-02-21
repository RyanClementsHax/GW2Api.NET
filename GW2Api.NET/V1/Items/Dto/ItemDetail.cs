using GW2Api.NET.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto
{
    public record ItemDetail(
        [property: JsonConverter(typeof(StringToIntConverter))] int ItemId,
        string Name,
        string Description,
        string Type,
        [property: JsonConverter(typeof(StringToIntConverter))] int Level,
        string Rarity,
        [property: JsonConverter(typeof(StringToIntConverter))] int VendorValue,
        [property: JsonConverter(typeof(StringToIntConverter))] int IconFileId,
        string IconFileSignature,
        [property: JsonConverter(typeof(StringToIntConverter))] int DefaultSkin,
        IReadOnlyCollection<string> GameTypes,
        IReadOnlyCollection<string> Flags,
        IReadOnlyCollection<string> Restrictions
    );
}
