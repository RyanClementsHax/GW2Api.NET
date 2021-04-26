using GW2Api.NET.Json.Attributes;
using System;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.RankChange
{
    [JsonDiscriminator("rank_change")]
    public record RankChange(
        int Id,
        DateTimeOffset Time,
        string User,

        string ChangedBy,
        string OldRank,
        string NewRank
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
