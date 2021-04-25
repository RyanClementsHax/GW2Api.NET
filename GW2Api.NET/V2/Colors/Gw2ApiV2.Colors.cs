using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Colors.Dto;
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
        public Task<IList<int>> GetAllColorIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("colors", token);

        public Task<Color> GetColorAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Color>(
                $"colors/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Color>> GetColorsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Color>>(
                "colors",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Color>> GetAllColorsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Color>>(
                "colors",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Color>>> GetColorsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Color>>(
                "colors",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
