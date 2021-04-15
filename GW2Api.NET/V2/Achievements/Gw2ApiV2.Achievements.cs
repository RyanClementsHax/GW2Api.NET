using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Achievements.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<int>> GetAllAchievementIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("achievements", token);

        public Task<Achievement> GetAchievementAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Achievement>(
                "achievements",
                new Dictionary<string, string>
                {
                    { "id", id.ToString() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<Achievement>> GetAchievementsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Achievement>>(
                "achievements",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }

        public Task<DailyAchievements> GetTodaysDailyAchievementsAsync(CancellationToken token = default)
            => GetAsync<DailyAchievements>("achievements/daily", token);

        public Task<DailyAchievements> GetTomorrowsDailyAchievementsAsync(CancellationToken token = default)
            => GetAsync<DailyAchievements>("achievements/daily/tomorrow", token);

        public Task<IList<Guid>> GetAllAchievementGroupIdsAsync(CancellationToken token = default)
            => GetAsync<IList<Guid>>("achievements/groups", token);

        public Task<AchievementGroup> GetAchievementGroupAsync(Guid id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<AchievementGroup>(
                $"achievements/groups/{id.ToUrlParam()}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<AchievementGroup>> GetAchievementGroupsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<AchievementGroup>>(
                "achievements/groups",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }
        public Task<IList<AchievementGroup>> GetAllAchievementGroupsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<AchievementGroup>>(
                "achievements/groups",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<int>> GetAllAchievementCategoryIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("achievements/categories", token);

        public Task<AchievementCategory> GetAchievementCategoryAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<AchievementCategory>(
                $"achievements/categories/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<AchievementCategory>> GetAchievementCategoriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<AchievementCategory>>(
                "achievements/categories",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }

        public Task<IList<AchievementCategory>> GetAllAchievementCategoriesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<AchievementCategory>>(
                "achievements/categories",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
    }
}
