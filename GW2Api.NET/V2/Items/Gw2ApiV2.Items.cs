using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Items.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<int>> GetFinisherIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("finishers", token);

        public Task<Finisher> GetFinisherAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Finisher>(
                $"finishers/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<Finisher>> GetFinishersAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Finisher>>(
                "finishers",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }

        public Task<Page<IList<Finisher>>> GetFinishersAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Finisher>>(
                "finishers",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllItemIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("items", token);
    }
}
