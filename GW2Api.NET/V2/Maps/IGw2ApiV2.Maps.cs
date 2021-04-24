using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Maps.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllContinentIdsAsync(CancellationToken token = default);
        Task<Continent> GetContinentAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Continent>> GetContinentsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Continent>> GetAllContinentsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Continent>>> GetContinentsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
