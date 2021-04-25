using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Novelties.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllNoveltyIdsAsync(CancellationToken token = default);
        Task<Novelty> GetNoveltyAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Novelty>> GetNoveltiesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Novelty>> GetAllNoveltiesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Novelty>>> GetNoveltiesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
