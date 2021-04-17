using GW2Api.NET.V2.Common;
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
        Task<IList<int>> GetAllMountSkinIdsAsync(CancellationToken token = default);
        Task<MountSkin> GetMountSkinAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<MountSkin>> GetMountSkinsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<MountSkin>> GetAllMountSkinsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<MountSkin>>> GetMountSkinsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<string>> GetAllMountTypeIdsAsync(CancellationToken token = default);
        Task<MountType> GetMountTypeAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<MountType>> GetMountTypesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<MountType>> GetAllMountTypesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<MountType>>> GetMountTypesAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
