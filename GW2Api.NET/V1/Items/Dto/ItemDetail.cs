using GW2Api.NET.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto
{
    [JsonConverter(typeof(AbstractClassConverter<ItemDetail>))]
    public record ItemDetail(
        [property: JsonConverter(typeof(StringToIntConverter))] int ItemId,
        string Name,
        string Description,
        [property: JsonConverter(typeof(StringToIntConverter))] int Level,
        Rarity Rarity,
        [property: JsonConverter(typeof(StringToIntConverter))] int VendorValue,
        [property: JsonConverter(typeof(StringToIntConverter))] int IconFileId,
        string IconFileSignature,
        IReadOnlyCollection<GameType> GameTypes,
        IReadOnlyCollection<ItemFlag> Flags,
        IReadOnlyCollection<Restriction> Restrictions
    );
}
