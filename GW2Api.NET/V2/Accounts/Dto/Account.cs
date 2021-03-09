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
        IReadOnlyCollection<Guid> Guilds,
        IReadOnlyCollection<Guid> GuildLeader,
        DateTimeOffset Created,
        IReadOnlyCollection<Content> Access,
        bool Commander,
        int FractalLevel,
        int DailyAp,
        int MonthlyAp,
        int WvwRank,
        DateTimeOffset LastModified
    );
}
