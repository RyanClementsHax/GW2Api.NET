using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Items.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetFinisherIdsAsync(CancellationToken token = default);
        Task<Finisher> GetFinisherAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Finisher>> GetFinishersAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Finisher>>> GetFinishersAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
