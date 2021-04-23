using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Guilds.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<Guild> GetGuildAsync(Guid id, CancellationToken token = default)
            => GetAsync<Guild>($"guild/{id}", token);

        public Task<IList<int>> GetAllEmblemBackgroundIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("emblem/backgrounds", token);

        public Task<EmblemLayer> GetEmblemBackgroundAsync(int id, CancellationToken token = default)
            => GetAsync<EmblemLayer>($"emblem/backgrounds/{id}", token);

        public Task<IList<EmblemLayer>> GetEmblemBackgroundsAsync(IEnumerable<int> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<EmblemLayer>>(
                "emblem/backgrounds",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<EmblemLayer>> GetAllEmblemBackgroundsAsync(CancellationToken token = default)
            => GetAsync<IList<EmblemLayer>>(
                "emblem/backgrounds",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<EmblemLayer>>> GetEmblemBackgroundsAsync(int page = 1, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<EmblemLayer>>(
                "emblem/backgrounds",
                new Dictionary<string, string> {}.ConfigurePage(page, pageSize),
                token
            );
    }
}
