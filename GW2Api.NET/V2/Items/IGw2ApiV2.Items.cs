using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Items.Dto;
using GW2Api.NET.V2.Items.Dto.Recipes;
using GW2Api.NET.V2.Items.Dto.Skins;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<int>> GetAllFinisherIdsAsync(CancellationToken token = default);
        Task<Finisher> GetFinisherAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Finisher>> GetFinishersAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Finisher>> GetAllFinishersAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Finisher>>> GetFinishersAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllItemIdsAsync(CancellationToken token = default);
        Task<Item> GetItemAync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Item>> GetItemsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllItemStatsIdsAsync(CancellationToken token = default);
        Task<ItemStats> GetItemStatsAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IEnumerable<ItemStats>> GetItemStatsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IEnumerable<ItemStats>> GetAllItemStatsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllMaterialIdsAsync(CancellationToken token = default);
        Task<Material> GetMaterialAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Material>> GetMaterialsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Material>> GetAllMaterialsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllRecipeIdsAsync(CancellationToken token = default);
        Task<Recipe> GetRecipeAsync(int id, CancellationToken token = default);
        Task<IList<Recipe>> GetRecipesAsync(IEnumerable<int> ids, CancellationToken token = default);
        Task<IList<int>> SearchRecipesByInput(int inputId, CancellationToken token = default);
        Task<IList<int>> SearchRecipesByOutput(int outputId, CancellationToken token = default);
        Task<IList<int>> GetAllSkinIdsAsync(CancellationToken token = default);
        Task<Skin> GetSkinAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Skin>> GetSkinsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
    }
}
