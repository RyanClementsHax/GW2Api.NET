using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Pvp.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<PvpStats> GetPvpStatsAsync(string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<PvpStats>("pvp/stats", accessToken, token);

        public Task<IList<Guid>> GetAllPvpGameIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<IList<Guid>>("pvp/games", accessToken, token);

        public Task<PvpGame> GetPvpGameAsync(Guid id, string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<PvpGame>(
                $"pvp/games/{id.ToUrlParam()}",
                accessToken,
                token
            );

        public Task<IList<PvpGame>> GetPvpGamesAsync(IEnumerable<Guid> ids, string accessToken = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetWithAuthAsync<IList<PvpGame>>(
                "pvp/games",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                accessToken,
                token
            );
        }

        public Task<IList<PvpGame>> Get10MostRecentPvpGamesAsync(string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<IList<PvpGame>>(
                "pvp/games",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                accessToken,
                token
            );

        public Task<Page<IList<PvpGame>>> GetPvpGamesAsync(int page = 0, int pageSize = -1, string accessToken = null, CancellationToken token = default)
            => GetPageWithAuthAsync<IList<PvpGame>>(
                "pvp/games",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                accessToken,
                token
            );

        public Task<IList<int>> GetAllPvpAmuletIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("pvp/amulets", token);

        public Task<PvpAmulet> GetPvpAmuletAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<PvpAmulet>(
                $"pvp/amulets/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<PvpAmulet>> GetPvpAmuletsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<PvpAmulet>>(
                "pvp/amulets",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<PvpAmulet>> GetAllPvpAmuletsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<PvpAmulet>>(
                "pvp/amulets",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<PvpAmulet>>> GetPvpAmuletsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<PvpAmulet>>(
                "pvp/amulets",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllPvpRankIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("pvp/ranks", token);

        public Task<PvpRank> GetPvpRankAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<PvpRank>(
                $"pvp/ranks/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<PvpRank>> GetPvpRanksAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<PvpRank>>(
                "pvp/ranks",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<PvpRank>> GetAllPvpRanksAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<PvpRank>>(
                "pvp/ranks",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<PvpRank>>> GetPvpRanksAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<PvpRank>>(
                "pvp/ranks",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<Guid>> GetAllPvpSeasonIdsAsync(CancellationToken token = default)
            => GetAsync<IList<Guid>>("pvp/seasons", token);

        public Task<PvpSeason> GetPvpSeasonAsync(Guid id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<PvpSeason>(
                $"pvp/seasons/{id.ToUrlParam()}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<PvpSeason>> GetPvpSeasonsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<PvpSeason>>(
                "pvp/seasons",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<PvpSeason>> GetAllPvpSeasonsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<PvpSeason>>(
                "pvp/seasons",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<PvpSeason>>> GetPvpSeasonsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<PvpSeason>>(
                "pvp/seasons",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<LeaderboardResult>> GetAllPvpLeaderboardResultsAsync(Guid seasonId, LeaderboardType leaderboardType, LeagueType leagueType, CancellationToken token = default)
            => GetAsync<IList<LeaderboardResult>>($"pvp/seasons/{seasonId.ToUrlParam()}/leaderboards/{leaderboardType.ToString().ToLower()}/{leagueType.ToString().ToLower()}", token);

        public Task<Page<IList<LeaderboardResult>>> GetPvpLeaderboardResultsAsync(Guid seasonId, LeaderboardType leaderboardType, LeagueType leagueType, int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<LeaderboardResult>>(
                $"pvp/seasons/{seasonId.ToUrlParam()}/leaderboards/{leaderboardType.ToString().ToLower()}/{leagueType.ToString().ToLower()}",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );
    }
}
