using GW2Api.NET.V2.Dailies.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<string>> GetAllAvailableTimeGatedRecipeIdsAsync(CancellationToken token = default);
        Task<TimeGatedRecipe> GetTimeGatedRecipeAsync(string id, CancellationToken token = default);
        Task<IList<TimeGatedRecipe>> GetTimeGatedRecipesAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<TimeGatedRecipe>> GetAllTimeGatedRecipesAsync(CancellationToken token = default);
        Task<IList<string>> GetAllAvailableMapChestIdsAsync(CancellationToken token = default);
        Task<MapChest> GetMapChestAsync(string id, CancellationToken token = default);
        Task<IList<MapChest>> GetMapChestsAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<MapChest>> GetAllMapChestsAsync(CancellationToken token = default);
    }
}
