using GW2Api.NET.V1.World.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _worldResource = "world_names.json";

        public Task<IList<WorldName>> GetAllWorldNamesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<WorldName>>(
                _worldResource,
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
    }
}
