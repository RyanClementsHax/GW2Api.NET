using GW2Api.NET.V1.Colors;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _colorsResource = "colors.json";

        public async Task<IDictionary<string, Color>> GetAllColorsAsync(CultureInfo cultureInfo)
            => (await GetAsync<ColorsResponse>(
                    _colorsResource,
                    new Dictionary<string, string>
                    {
                        { "lang", cultureInfo.TwoLetterISOLanguageName }
                    }
                )).Colors;

        public async Task<IDictionary<string, Color>> GetAllColorsAsync(CultureInfo cultureInfo, CancellationToken token)
            => (await GetAsync<ColorsResponse>(
                    _colorsResource,
                    new Dictionary<string, string>
                    {
                        { "lang", cultureInfo.TwoLetterISOLanguageName }
                    },
                    token
                )).Colors;
    }
}
