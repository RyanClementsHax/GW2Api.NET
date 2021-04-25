using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Home.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<int>> GetAllHomeCatIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("home/cats", token);

        public Task<HomeCat> GetHomeCatAsync(int id, CancellationToken token = default)
            => GetAsync<HomeCat>($"home/cats/{id}", token);

        public Task<IList<HomeCat>> GetHomeCatsAsync(IEnumerable<int> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<HomeCat>>(
                "home/cats",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<HomeCat>> GetAllHomeCatsAsync(CancellationToken token = default)
            => GetAsync<IList<HomeCat>>(
                "home/cats",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<HomeCat>>> GetHomeCatsAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<HomeCat>>(
                "home/cats",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllHomeNodeIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("home/nodes", token);

        public Task<HomeNode> GetHomeNodeAsync(string id, CancellationToken token = default)
            => GetAsync<HomeNode>($"home/nodes/{id}", token);

        public Task<IList<HomeNode>> GetHomeNodesAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<HomeNode>>(
                "home/nodes",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<HomeNode>> GetAllHomeNodesAsync(CancellationToken token = default)
            => GetAsync<IList<HomeNode>>(
                "home/nodes",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<HomeNode>>> GetHomeNodesAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<HomeNode>>(
                "home/nodes",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );
    }
}
