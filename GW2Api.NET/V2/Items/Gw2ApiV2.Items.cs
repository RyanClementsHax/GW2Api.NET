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
        public Task<IList<int>> GetAllFinisherIdsAsync(CancellationToken token = default)
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

        public Task<IList<Finisher>> GetAllFinishersAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Finisher>>(
                "finishers",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

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

        public Task<Item> GetItemAync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Item>(
                $"items/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<Item>> GetItemsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Item>>(
                $"items",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<int>> GetAllItemStatsIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("itemstats", token);

        public Task<ItemStats> GetItemStatsAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<ItemStats>(
                $"itemstats/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IEnumerable<ItemStats>> GetItemStatsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IEnumerable<ItemStats>>(
                "itemstats",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }

        public Task<IEnumerable<ItemStats>> GetAllItemStatsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IEnumerable<ItemStats>>(
                "itemstats",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<int>> GetAllMaterialIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("materials", token);

        public Task<Material> GetMaterialAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Material>(
                $"materials/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );

        public Task<IList<Material>> GetMaterialsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Material>>(
                "materials",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
        }

        public Task<IList<Material>> GetAllMaterialsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Material>>(
                "materials",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
    }
}
