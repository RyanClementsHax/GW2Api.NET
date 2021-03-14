using GW2Api.NET.V2.Achievements.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllAchievementIdsAsync(CancellationToken token = default);
        Task<Achievement> GetAchievementAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Achievement>> GetAchievementsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<DailyAchievements> GetTodaysDailyAchievementsAsync(CancellationToken token = default);
        Task<DailyAchievements> GetTomorrowsDailyAchievementsAsync(CancellationToken token = default);
        Task<IList<Guid>> GetAllAchievementGroupIdsAsync(CancellationToken token = default);
        Task<AchievementGroup> GetAchievementGroupAsync(Guid id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<AchievementGroup>> GetAchievementGroupsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllAchievementCategoryIdsAsync(CancellationToken token = default);
        Task<AchievementCategory> GetAchievementCategoryAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<AchievementCategory>> GetAchievementCategoriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
    }
}
