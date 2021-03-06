﻿using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Dailies.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<string>> GetAllTimeGatedRecipeIdsAsync(CancellationToken token = default);
        Task<TimeGatedRecipe> GetTimeGatedRecipeAsync(string id, CancellationToken token = default);
        Task<IList<TimeGatedRecipe>> GetTimeGatedRecipesAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<TimeGatedRecipe>> GetAllTimeGatedRecipesAsync(CancellationToken token = default);
        Task<Page<IList<TimeGatedRecipe>>> GetTimeGatedRecipesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
        Task<IList<string>> GetAllMapChestIdsAsync(CancellationToken token = default);
        Task<MapChest> GetMapChestAsync(string id, CancellationToken token = default);
        Task<IList<MapChest>> GetMapChestsAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<MapChest>> GetAllMapChestsAsync(CancellationToken token = default);
        Task<Page<IList<MapChest>>> GetMapChestsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
        Task<IList<string>> GetAllWorldBossIdsAsync(CancellationToken token = default);
        Task<WorldBoss> GetWorldBossAsync(string id, CancellationToken token = default);
        Task<IList<WorldBoss>> GetWorldBossesAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<WorldBoss>> GetAllWorldBossesAsync(CancellationToken token = default);
        Task<Page<IList<WorldBoss>>> GetWorldBossesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
    }
}
