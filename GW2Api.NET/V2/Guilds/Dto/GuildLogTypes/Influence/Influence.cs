using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto.GuildLogTypes.Influence
{
    public record Influence(
        int Id,
        DateTimeOffset Time,
        string User,

        InfluenceActivity Activity,
        int TotalParticipants,
        IList<string> Participants
    ) : GuildLog(
        Id,
        Time,
        User
    );
}
