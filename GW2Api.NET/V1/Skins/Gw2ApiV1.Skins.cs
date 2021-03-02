using GW2Api.NET.V1.Skins.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _skinsResource = "skins.json";
        private static readonly string _skinDetailsResource = "skin_details.json";

        public async Task<IReadOnlyCollection<int>> GetAllSkinIdsAsync(CancellationToken token = default)
            => (await GetAsync<GetAllSkinIdsResponse>(
                _skinsResource,
                token
            )).Skins;

        public Task<SkinDetail> GetSkinDetailAsync(int skinId, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<SkinDetail>(
                    _skinDetailsResource,
                    new Dictionary<string, string>
                    {
                        { "skin_id", skinId.ToString() },
                        { "lang", lang?.TwoLetterISOLanguageName }
                    },
                    token
                );
    }
}
