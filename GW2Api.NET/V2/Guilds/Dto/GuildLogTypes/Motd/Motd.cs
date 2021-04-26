using GW2Api.NET.Json.Attributes;
using System;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.Motd
{
    [JsonDiscriminator("motd")]
    public record MessageOfTheDay(
        int Id,
        DateTimeOffset Time,
        string User,

        string Motd
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
