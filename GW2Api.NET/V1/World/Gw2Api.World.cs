using GW2Api.NET.V1.World;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _worldResource = "world_names.json";

        public Task<IReadOnlyCollection<WorldName>> GetAllWorldNames(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IReadOnlyCollection<WorldName>>(
                _worldResource,
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
    }
}
