using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Worlds.Dto;
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
        public Task<IList<int>> GetAllWorldIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("worlds", token);

        public Task<World> GetWorldAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<World>(
                $"worlds/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<World>> GetWorldsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<World>>(
                "worlds",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<World>> GetAllWorldsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<World>>(
                "worlds",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<World>>> GetWorldsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<World>>(
                "worlds",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
