using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Pvp.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        Task<Page<IList<PvpGame>>> GetPvpGamesAsync(int page = 0, int pageSize = -1, string accessToken = null, CancellationToken token = default);
        Task<IList<int>> GetAllPvpAmuletIdsAsync(CancellationToken token = default);
        Task<PvpAmulet> GetPvpAmuletAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<PvpAmulet>> GetPvpAmuletsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<PvpAmulet>> GetAllPvpAmuletsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<PvpAmulet>>> GetPvpAmuletsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllPvpRankIdsAsync(CancellationToken token = default);
        Task<PvpRank> GetPvpRankAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<PvpRank>> GetPvpRanksAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<PvpRank>> GetAllPvpRanksAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<PvpRank>>> GetPvpRanksAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Guid>> GetAllPvpSeasonIdsAsync(CancellationToken token = default);
        Task<PvpSeason> GetPvpSeasonAsync(Guid id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<PvpSeason>> GetPvpSeasonsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<PvpSeason>> GetAllPvpSeasonsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<PvpSeason>>> GetPvpSeasonsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<LeaderboardResult>> GetAllPvpLeaderboardResultsAsync(Guid seasonId, LeaderboardType leaderboardType, LeagueType leagueType, CancellationToken token = default);
        Task<Page<IList<LeaderboardResult>>> GetPvpLeaderboardResultsAsync(Guid seasonId, LeaderboardType leaderboardType, LeagueType leagueType, int page = 0, int pageSize = -1, CancellationToken token = default);
    }
}
