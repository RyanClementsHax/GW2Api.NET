using GW2Api.NET.V2.GameMechanics.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllMasteryIdsAsync(CancellationToken token = default);
        Task<Mastery> GetMasteryAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Mastery>> GetMasteriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Mastery>> GetAllMasteriesAsync(CultureInfo lang = null, CancellationToken token = default);
    }
}
