using GW2Api.NET.V2.Achievements.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IReadOnlyCollection<int>> GetAllAchievementIdsAsync(CancellationToken token = default);
        Task<Achievement> GetAchievementAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IEnumerable<Achievement>> GetAchievementsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
    }
}
