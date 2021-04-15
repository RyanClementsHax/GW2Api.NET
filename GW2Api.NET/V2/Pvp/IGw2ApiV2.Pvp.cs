using GW2Api.NET.V2.Pvp.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<PvpStats> GetPvpStatsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<Guid>> GetAllPvpGameIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<PvpGame> GetPvpGameAsync(Guid id, string accessToken = null, CancellationToken token = default);
        Task<IList<PvpGame>> GetPvpGamesAsync(IEnumerable<Guid> ids, string accessToken = null, CancellationToken token = default);
        Task<IList<PvpGame>> Get10MostRecentPvpGamesAsync(string accessToken = null, CancellationToken token = default);
    }
}
