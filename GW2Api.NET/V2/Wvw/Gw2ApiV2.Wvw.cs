using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Wvw.Dto;
using GW2Api.NET.V2.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<int>> GetAllWvwAbilityIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("wvw/abilities", token);

        public Task<WvwAbility> GetWvwAbilityAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<WvwAbility>(
                $"wvw/abilities/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<WvwAbility>> GetWvwAbilitiesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WvwAbility>>(
                "wvw/abilities",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WvwAbility>> GetAllWvwAbilitiesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<WvwAbility>>(
                "wvw/abilities",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<WvwAbility>>> GetWvwAbilitiesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<WvwAbility>>(
                "wvw/abilities",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllWvwMatchIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("wvw/matches", token);

        public Task<WvwMatch> GetWvwMatchAsync(int world, CancellationToken token = default)
            => GetAsync<WvwMatch>(
                "wvw/matches",
                new Dictionary<string, string>
                {
                    { "world", world.ToString() }
                },
                token
            );

        public Task<WvwMatch> GetWvwMatchAsync(string id, CancellationToken token = default)
            => GetAsync<WvwMatch>($"wvw/matches/{id}", token);

        public Task<IList<WvwMatch>> GetWvwMatchesAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WvwMatch>>(
                "wvw/matches",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WvwMatch>> GetAllWvwMatchesAsync(CancellationToken token = default)
            => GetAsync<IList<WvwMatch>>(
                "wvw/matches",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<WvwMatch>>> GetWvwMatchesAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<WvwMatch>>(
                "wvw/matches",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllWvwOverviewIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("wvw/matches/overview", token);

        public Task<WvwOverview> GetWvwOverviewAsync(int world, CancellationToken token = default)
            => GetAsync<WvwOverview>(
                "wvw/matches/overview",
                new Dictionary<string, string>
                {
                    { "world", world.ToString() }
                },
                token
            );

        public Task<WvwOverview> GetWvwOverviewAsync(string id, CancellationToken token = default)
            => GetAsync<WvwOverview>($"wvw/matches/overview/{id}", token);

        public Task<IList<WvwOverview>> GetWvwOverviewsAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WvwOverview>>(
                "wvw/matches/overview",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WvwOverview>> GetAllWvwOverviewsAsync(CancellationToken token = default)
            => GetAsync<IList<WvwOverview>>(
                "wvw/matches/overview",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<WvwOverview>>> GetWvwOverviewsAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<WvwOverview>>(
                "wvw/matches/overview",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllWvwScoreIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("wvw/matches/scores", token);

        public Task<WvwScore> GetWvwScoreAsync(int world, CancellationToken token = default)
            => GetAsync<WvwScore>(
                "wvw/matches/scores",
                new Dictionary<string, string>
                {
                    { "world", world.ToString() }
                },
                token
            );

        public Task<WvwScore> GetWvwScoreAsync(string id, CancellationToken token = default)
            => GetAsync<WvwScore>($"wvw/matches/scores/{id}", token);

        public Task<IList<WvwScore>> GetWvwScoresAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WvwScore>>(
                "wvw/matches/scores",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WvwScore>> GetAllWvwScoresAsync(CancellationToken token = default)
            => GetAsync<IList<WvwScore>>(
                "wvw/matches/scores",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<WvwScore>>> GetWvwScoresAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<WvwScore>>(
                "wvw/matches/scores",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllWvwStatsIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("wvw/matches/stats", token);

        public Task<WvwStats> GetWvwStatsAsync(int world, CancellationToken token = default)
            => GetAsync<WvwStats>(
                "wvw/matches/stats",
                new Dictionary<string, string>
                {
                    { "world", world.ToString() }
                },
                token
            );

        public Task<WvwStats> GetWvwStatsAsync(string id, CancellationToken token = default)
            => GetAsync<WvwStats>($"wvw/matches/stats/{id}", token);

        public Task<IList<WvwStats>> GetWvwStatsAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WvwStats>>(
                "wvw/matches/stats",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WvwStats>> GetAllWvwStatsAsync(CancellationToken token = default)
            => GetAsync<IList<WvwStats>>(
                "wvw/matches/stats",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<WvwStats>>> GetWvwStatsAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<WvwStats>>(
                "wvw/matches/stats",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllWvwObjectiveIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("wvw/objectives", token);

        public Task<WvwObjective> GetWvwObjectiveAsync(string id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<WvwObjective>(
                $"wvw/objectives/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<WvwObjective>> GetWvwObjectivesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WvwObjective>>(
                "wvw/objectives",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WvwObjective>> GetAllWvwObjectivesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<WvwObjective>>(
                "wvw/objectives",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<WvwObjective>>> GetWvwObjectivesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<WvwObjective>>(
                "wvw/objectives",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
        public Task<IList<int>> GetAllWvwRankIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("wvw/ranks", token);

        public Task<WvwRank> GetWvwRankAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<WvwRank>(
                $"wvw/ranks/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<WvwRank>> GetWvwRanksAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WvwRank>>(
                "wvw/ranks",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WvwRank>> GetAllWvwRanksAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<WvwRank>>(
                "wvw/ranks",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<WvwRank>>> GetWvwRanksAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<WvwRank>>(
                "wvw/ranks",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
