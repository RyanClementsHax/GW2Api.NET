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
    }
}
