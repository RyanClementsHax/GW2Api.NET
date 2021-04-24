using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Currencies.Dto;
using GW2Api.NET.V2.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<int>> GetAllCurrencyIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("currencies", token);

        public Task<Currency> GetCurrencyAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Currency>(
                $"currencies/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Currency>> GetCurrenciesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Currency>>(
                "currencies",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Currency>> GetAllCurrenciesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Currency>>(
                "currencies",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Currency>>> GetCurrenciesAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Currency>>(
                "currencies",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
