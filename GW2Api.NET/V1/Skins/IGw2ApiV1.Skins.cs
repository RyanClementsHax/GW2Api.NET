using GW2Api.NET.V1.Skins.Dto;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IReadOnlyCollection<int>> GetAllSkinIdsAsync(CancellationToken token = default);
        Task<SkinDetail> GetSkinDetailAsync(int skinId, CultureInfo lang = null, CancellationToken token = default);
    }
}
