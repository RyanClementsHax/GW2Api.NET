using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Guilds.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<Guild> GetGuildAsync(Guid id, CancellationToken token = default);
        Task<IList<int>> GetAllEmblemBackgroundIdsAsync(CancellationToken token = default);
        Task<EmblemLayer> GetEmblemBackgroundAsync(int id, CancellationToken token = default);
        Task<IList<EmblemLayer>> GetEmblemBackgroundsAsync(IEnumerable<int> ids, CancellationToken token = default);
        Task<IList<EmblemLayer>> GetAllEmblemBackgroundsAsync(CancellationToken token = default);
        Task<Page<IList<EmblemLayer>>> GetEmblemBackgroundsAsync(int page = 1, int pageSize = -1, CancellationToken token = default);
    }
}
