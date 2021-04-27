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
            => GetAsync<IList<string>>("wvw/matches", token);

        public Task<WvwOverview> GetWvwOverviewAsync(int world, CancellationToken token = default)
            => GetAsync<WvwOverview>(
                "wvw/matches",
                new Dictionary<string, string>
                {
                    { "world", world.ToString() }
                },
                token
            );

        public Task<WvwOverview> GetWvwOverviewAsync(string id, CancellationToken token = default)
            => GetAsync<WvwOverview>($"wvw/matches/{id}", token);

        public Task<IList<WvwOverview>> GetWvwOverviewesAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WvwOverview>>(
                "wvw/matches",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WvwOverview>> GetAllWvwOverviewesAsync(CancellationToken token = default)
            => GetAsync<IList<WvwOverview>>(
                "wvw/matches",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<WvwOverview>>> GetWvwOverviewesAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<WvwOverview>>(
                "wvw/matches",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );
    }
}
