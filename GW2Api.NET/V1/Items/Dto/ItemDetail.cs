﻿using GW2Api.NET.Json.Converters;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V1.Items.Dto
{
    [JsonConverter(typeof(AbstractClassConverter<ItemDetail>))]
    public abstract record ItemDetail(
        [property: JsonConverter(typeof(StringToIntConverter))] int ItemId,
        string Name,
        string Description,
        [property: JsonConverter(typeof(StringToIntConverter))] int Level,
        Rarity Rarity,
        [property: JsonConverter(typeof(StringToIntConverter))] int VendorValue,
        [property: JsonConverter(typeof(StringToIntConverter))] int IconFileId,
        string IconFileSignature,
        IList<GameType> GameTypes,
        IList<ItemFlag> Flags,
        IList<Restriction> Restrictions
    );
}
