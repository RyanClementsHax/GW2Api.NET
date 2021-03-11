using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Achievements.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        private static readonly string _achievementsResource = "achievements";
        private static readonly string _achievementsDailyResource = "achievements/daily";
        private static readonly string _achievementsDailyTomorrowResource = "achievements/daily/tomorrow";
        private static readonly string _achievementsGroupsResource = "achievements/groups";
        private static readonly string _achievementsCategoriesResource = "achievements/categories";

        public Task<IReadOnlyCollection<int>> GetAllAchievementIdsAsync(CancellationToken token = default)
            => GetAsync<IReadOnlyCollection<int>>(_achievementsResource, token);

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

        public Task<IEnumerable<Achievement>> GetAchievementsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IEnumerable<Achievement>>(
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
            => GetAsync<DailyAchievements>(_achievementsDailyResource, token);

        public Task<DailyAchievements> GetTomorrowsDailyAchievementsAsync(CancellationToken token = default)
            => GetAsync<DailyAchievements>(_achievementsDailyTomorrowResource, token);

        public Task<IReadOnlyCollection<Guid>> GetAllAchievementGroupIdsAsync(CancellationToken token = default)
            => GetAsync<IReadOnlyCollection<Guid>>(_achievementsGroupsResource, token);

        public Task<AchievementGroup> GetAchievementGroupAsync(Guid id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<AchievementGroup>(
                $"{_achievementsGroupsResource}/{id.ToString().ToUpper()}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        public Task<IEnumerable<AchievementGroup>> GetAchievementGroupsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IEnumerable<AchievementGroup>>(
                _achievementsGroupsResource,
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }

        public Task<IReadOnlyCollection<int>> GetAllAchievementCategoryIdsAsync(CancellationToken token = default)
            => GetAsync<IReadOnlyCollection<int>>(_achievementsCategoriesResource, token);

        public Task<AchievementCategory> GetAchievementCategoryAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<AchievementCategory>(
                $"{_achievementsCategoriesResource}/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IEnumerable<AchievementCategory>> GetAchievementCategoriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IEnumerable<AchievementCategory>>(
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
