using GW2Api.NET.V1.Wvw.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _wvwMatchResource = "wvw/matches.json";
        private static readonly string _wvwMatchDetailsResource = "wvw/match_details.json";
        private static readonly string _wvwObjectiveNamesResource = "wvw/objective_names.json";

        public async Task<IReadOnlyCollection<WvwMatch>> GetAllWvwMatchesAsync(CancellationToken token = default)
            => (await GetAsync<GetAllWvwMatchesResponse>(
                _wvwMatchResource,
                token
            )).WvwMatches;

        public Task<WvwMatchDetail> GetWvwMatchDetailAsync(string matchId, CancellationToken token = default)
            => GetAsync<WvwMatchDetail>(
                _wvwMatchDetailsResource,
                new Dictionary<string, string>
                {
                    { "match_id", matchId }
                },
                token
            );

        public Task<IReadOnlyCollection<ObjectiveName>> GetWvwObjectiveNamesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IReadOnlyCollection<ObjectiveName>>(
                _wvwObjectiveNamesResource,
                new Dictionary<string, string>
                {
                    { "lang", lang?.TwoLetterISOLanguageName }
                },
                token
            );
    }
}
