using GW2Api.NET.V2.Common;
using System;
using System.Collections.Generic;

namespace GW2Api.NET.V2.Accounts.Dto
{
    public record Account(
        Guid Id,
        int Age,
        string Name,
        int World,
        IList<Guid> Guilds,
        IList<Guid> GuildLeader,
        DateTimeOffset Created,
        IList<Content> Access,
        bool Commander,
        int FractalLevel,
        int DailyAp,
        int MonthlyAp,
        int WvwRank,
        DateTimeOffset LastModified
    );
}
