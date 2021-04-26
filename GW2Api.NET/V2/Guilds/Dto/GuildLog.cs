using GW2Api.NET.Json.Converters;
using System;
using System.Text.Json.Serialization;

namespace GW2Api.NET.V2.Guilds.Dto
{
    [JsonConverter(typeof(AbstractClassConverter<GuildLog>))]
    public abstract record GuildLog(
        int Id,
        DateTimeOffset Time,
        string User
    );
}
