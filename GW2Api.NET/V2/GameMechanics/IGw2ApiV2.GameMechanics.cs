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
        Task<IList<int>> GetAllOutfitIdsAsync(CancellationToken token = default);
        Task<Outfit> GetOutfitAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Outfit>> GetOutfitsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Outfit>> GetAllOutfitsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Outfit>>> GetOutfitsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllPetIdsAsync(CancellationToken token = default);
        Task<Pet> GetPetAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Pet>> GetPetsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Pet>> GetAllPetsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Pet>>> GetPetsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
