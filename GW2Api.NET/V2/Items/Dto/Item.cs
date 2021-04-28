using GW2Api.NET.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V2.Items.Dto
{
    [JsonConverter(typeof(AbstractClassConverter<Item>))]
    public abstract record Item(
        int Id,
        string ChatLink,
        string Name,
        Uri Icon,
        string Description,
        Rarity Rarity,
        int Level,
        int VendorValue,
        int? DefaultSkin,
        IList<ItemFlag> Flags,
        IList<GameType> GameTypes,
        IList<Restriction> Restrictions,
        IList<UpgradeInfo> UpgradesInto,
        IList<UpgradeInfo> UpgradesFrom
    );
}
