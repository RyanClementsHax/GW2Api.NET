using GW2Api.NET.V1.Wvw.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyCollection<WvwMatch>> GetAllWvwMatchesAsync(CancellationToken token = default);
        Task<WvwMatchDetail> GetWvwMatchDetailAsync(string matchId, CancellationToken token = default);
        Task<IReadOnlyCollection<ObjectiveName>> GetWvwObjectiveNamesAsync(CultureInfo lang = null, CancellationToken token = default);
    }
}
