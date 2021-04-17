using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Dailies.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<string>> GetAllAvailableTimeGatedRecipeIdsAsync(CancellationToken token = default)
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
    }
}
