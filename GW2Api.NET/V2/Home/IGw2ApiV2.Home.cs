using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Home.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllHomeCatIdsAsync(CancellationToken token = default);
        Task<HomeCat> GetHomeCatAsync(int id, CancellationToken token = default);
        Task<IList<HomeCat>> GetHomeCatsAsync(IEnumerable<int> ids, CancellationToken token = default);
        Task<IList<HomeCat>> GetAllHomeCatsAsync(CancellationToken token = default);
        Task<Page<IList<HomeCat>>> GetHomeCatsAsync(int page = 1, int pageSize = -1, CancellationToken token = default);
        Task<IList<string>> GetAllHomeNodeIdsAsync(CancellationToken token = default);
        Task<HomeNode> GetHomeNodeAsync(string id, CancellationToken token = default);
        Task<IList<HomeNode>> GetHomeNodesAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<HomeNode>> GetAllHomeNodesAsync(CancellationToken token = default);
        Task<Page<IList<HomeNode>>> GetHomeNodesAsync(int page = 1, int pageSize = -1, CancellationToken token = default);
    }
}
