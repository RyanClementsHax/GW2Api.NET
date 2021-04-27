using GW2Api.NET.V2.Pvp.Dto;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Guilds.Dto
{
    public record GuildTeam(
        int Id,
        IList<GuildTeamMember> Members,
        string Name,
        GuildTeamState State,
        WinLossStats Aggregate,
        IDictionary<Ladder, WinLossStats> Ladders,
        IList<PvpGame> Games,
        IList<GuildSeasonInfo> Seasons
    );
}
