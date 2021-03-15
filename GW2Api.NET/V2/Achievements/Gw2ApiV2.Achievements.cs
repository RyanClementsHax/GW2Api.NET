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
        private static readonly string _achievementsResource = "achievements";

        public Task<IList<int>> GetAllAchievementIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>(_achievementsResource, token);

        public Task<Achievement> GetAchievementAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Achievement>(
                _achievementsResource,
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
                _achievementsResource,
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

        private static readonly string _achievementsGroupsResource = "achievements/groups";

        public Task<IList<Guid>> GetAllAchievementGroupIdsAsync(CancellationToken token = default)
            => GetAsync<IList<Guid>>(_achievementsGroupsResource, token);

        public Task<AchievementGroup> GetAchievementGroupAsync(Guid id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<AchievementGroup>(
                $"{_achievementsGroupsResource}/{id.ToString().ToUpper()}",
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
                _achievementsGroupsResource,
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }

        private static readonly string _achievementsCategoriesResource = "achievements/categories";

        public Task<IList<int>> GetAllAchievementCategoryIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>(_achievementsCategoriesResource, token);

        public Task<AchievementCategory> GetAchievementCategoryAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<AchievementCategory>(
                $"{_achievementsCategoriesResource}/{id}",
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
                _achievementsCategoriesResource,
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }
    }
}
