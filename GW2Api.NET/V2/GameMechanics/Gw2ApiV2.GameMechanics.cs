using GW2Api.NET.Helpers;
using GW2Api.NET.V2.GameMechanics.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<int>> GetAllMasteryIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("masteries", token);

        public Task<Mastery> GetMasteryAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Mastery>(
                $"masteries/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<Mastery>> GetMasteriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Mastery>>(
                "masteries",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }

        public Task<IList<Mastery>> GetAllMasteriesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Mastery>>(
                "masteries",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
    }
}
