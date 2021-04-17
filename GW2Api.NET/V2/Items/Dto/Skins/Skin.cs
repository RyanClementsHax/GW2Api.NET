using GW2Api.NET.Json.Converters;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V2.Items.Dto.Skins
{
    [JsonConverter(typeof(AbstractClassConverter<Skin>))]
    public abstract record Skin(
        int Id,
        string Name,
        SkinType Type,
        IList<SkinFlag> Flags,
        IList<Restriction> Restrictions,
        string Icon,
        Rarity Rarity,
        string Description
    );
}
