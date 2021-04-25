using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Dailies.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<string>> GetAllTimeGatedRecipeIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("dailycrafting", token);

        public Task<TimeGatedRecipe> GetTimeGatedRecipeAsync(string id, CancellationToken token = default)
            => GetAsync<TimeGatedRecipe>($"dailycrafting/{id}", token);

        public Task<IList<TimeGatedRecipe>> GetTimeGatedRecipesAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<TimeGatedRecipe>>(
                "dailycrafting",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<TimeGatedRecipe>> GetAllTimeGatedRecipesAsync(CancellationToken token = default)
            => GetAsync<IList<TimeGatedRecipe>>(
                "dailycrafting",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<TimeGatedRecipe>>> GetTimeGatedRecipesAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<TimeGatedRecipe>>(
                "dailycrafting",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllMapChestIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("mapchests", token);

        public Task<MapChest> GetMapChestAsync(string id, CancellationToken token = default)
            => GetAsync<MapChest>($"mapchests/{id}", token);

        public Task<IList<MapChest>> GetMapChestsAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<MapChest>>(
                "mapchests",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<MapChest>> GetAllMapChestsAsync(CancellationToken token = default)
            => GetAsync<IList<MapChest>>(
                "mapchests",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<MapChest>>> GetMapChestsAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<MapChest>>(
                "mapchests",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllWorldBossIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("worldbosses", token);

        public Task<WorldBoss> GetWorldBossAsync(string id, CancellationToken token = default)
            => GetAsync<WorldBoss>($"worldbosses/{id}", token);

        public Task<IList<WorldBoss>> GetWorldBossesAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<WorldBoss>>(
                "worldbosses",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<WorldBoss>> GetAllWorldBossesAsync(CancellationToken token = default)
            => GetAsync<IList<WorldBoss>>(
                "worldbosses",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<WorldBoss>>> GetWorldBossesAsync(int page = 0, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<WorldBoss>>(
                "worldbosses",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );
    }
}
