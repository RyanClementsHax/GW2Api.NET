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
            if (ids is null) throw new ArgumentNullException(nameof(ids));

            return GetAsync<IEnumerable<Achievement>>(
                _achievementsResource,
                new Dictionary<string, string>
                {
                    { "ids", string.Join(",", ids.Select(x => x.ToString()))},
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }
    }
}
