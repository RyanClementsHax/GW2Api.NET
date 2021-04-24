using GW2Api.NET.V2.Currencies.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllCurrencyIdsAsync(CancellationToken token = default);
        Task<Currency> GetCurrencyAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Currency>> GetCurrenciesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Currency>> GetAllCurrenciesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Currency>>> GetCurrenciesAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
