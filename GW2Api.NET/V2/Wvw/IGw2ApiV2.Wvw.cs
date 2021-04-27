using GW2Api.NET.V2.Wvw.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllWvwAbilityIdsAsync(CancellationToken token = default);
        Task<WvwAbility> GetWvwAbilityAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<WvwAbility>> GetWvwAbilitiesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<WvwAbility>> GetAllWvwAbilitiesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<WvwAbility>>> GetWvwAbilitiesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<string>> GetAllWvwMatchIdsAsync(CancellationToken token = default);
        Task<WvwMatch> GetWvwMatchAsync(int world, CancellationToken token = default);
        Task<WvwMatch> GetWvwMatchAsync(string id, CancellationToken token = default);
        Task<IList<WvwMatch>> GetWvwMatchesAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<WvwMatch>> GetAllWvwMatchesAsync(CancellationToken token = default);
        Task<Page<IList<WvwMatch>>> GetWvwMatchesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
    }
}
