using GW2Api.NET.V1.Maps.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _mapsResource = "map_names.json";

        public Task<IReadOnlyCollection<MapName>> GetAllMapNamesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IReadOnlyCollection<MapName>>(
                _mapsResource,
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
    }
}
