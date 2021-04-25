using GW2Api.NET.V2.Worlds.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllWorldIdsAsync(CancellationToken token = default);
        Task<World> GetWorldAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<World>> GetWorldsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<World>> GetAllWorldsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<World>>> GetWorldsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
