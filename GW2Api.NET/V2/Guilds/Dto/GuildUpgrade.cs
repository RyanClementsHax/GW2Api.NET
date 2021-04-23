using GW2Api.NET.Json.Converters;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V2.Guilds.Dto
{
    [JsonConverter(typeof(AbstractClassConverter<GuildUpgrade>))]
    public abstract record GuildUpgrade(
        int Id,
        string Name,
        string Description,
        string Icon,
        int BuildTime,
        int RequiredLevel,
        int Experience,
        IList<int> Prerequisites,
        IList<GuildUpgradeCost> Costs
    );
}
