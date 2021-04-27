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
        Task<IList<string>> GetAllWvwOverviewIdsAsync(CancellationToken token = default);
        Task<WvwOverview> GetWvwOverviewAsync(int world, CancellationToken token = default);
        Task<WvwOverview> GetWvwOverviewAsync(string id, CancellationToken token = default);
        Task<IList<WvwOverview>> GetWvwOverviewsAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<WvwOverview>> GetAllWvwOverviewsAsync(CancellationToken token = default);
        Task<Page<IList<WvwOverview>>> GetWvwOverviewsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
        Task<IList<string>> GetAllWvwScoreIdsAsync(CancellationToken token = default);
        Task<WvwScore> GetWvwScoreAsync(int world, CancellationToken token = default);
        Task<WvwScore> GetWvwScoreAsync(string id, CancellationToken token = default);
        Task<IList<WvwScore>> GetWvwScoresAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<WvwScore>> GetAllWvwScoresAsync(CancellationToken token = default);
        Task<Page<IList<WvwScore>>> GetWvwScoresAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
    }
}
