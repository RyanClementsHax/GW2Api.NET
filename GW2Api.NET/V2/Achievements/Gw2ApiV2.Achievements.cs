using GW2Api.NET.V2.Achievements.Dto;
using System.Collections.Generic;
using System.Globalization;
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
    }
}
