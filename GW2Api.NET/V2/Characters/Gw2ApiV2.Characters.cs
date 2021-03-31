using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Characters.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<string>> GetCharacterIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>("characters", accessToken, token);

        public Task<Character> GetCharacterAsync(string id, string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<Character>($"characters/{id}", accessToken, token);

        public Task<IList<Character>> GetCharactersAsync(IEnumerable<string> ids, string accessToken = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAuthenticatedAsync<IList<Character>>(
                "characters",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                },
                accessToken,
                token
            );
        }

        public Task<IList<Character>> GetAllCharactersAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<Character>>(
                "characters",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                },
                accessToken,
                token
            );

        public async Task<IList<string>> GetCharacterBackstoryAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<GetCharacterBackstoryResponse>($"characters/{id}/backstory", accessToken, token)).Backstory;

        public Task<CharacterCore> GetCharacterCoreAsync(string id, string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<CharacterCore>($"characters/{id}/core", accessToken, token);

        public async Task<IList<CraftingDiscipline>> GetCharacterCraftingAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<GetCharacterCraftingResponse>($"characters/{id}/crafting", accessToken, token)).Crafting;

        public async Task<IList<Equipment>> GetCharacterEquipmentAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<GetCharacterEquipmentResponse>($"characters/{id}/equipment", accessToken, token)).Equipment;

        public Task<IList<string>> GetCharacterHeroPointsAsync(string id, string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>($"characters/{id}/heropoints", accessToken, token);

        public async Task<IList<Bag>> GetCharacterInventoryAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<GetCharacterInventoryResponse>($"characters/{id}/inventory", accessToken, token)).Bags;

        public async Task<IList<int>> GetCharacterRecipesAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<GetCharacterRecipesResponse>($"characters/{id}/recipes", accessToken, token)).Recipes;

        public Task<Sab> GetCharacterSabAsync(string id, string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<Sab>($"characters/{id}/sab", accessToken, token);

        public async Task<Skills> GetCharacterSkillsAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<GetCharacterSkillsResponse>($"characters/{id}/skills", accessToken, token)).Skills;

        public async Task<Specializations> GetCharacterSpecializationsAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<GetCharacterSpecializationsResponse>($"characters/{id}/specializations", accessToken, token)).Specializations;

        public async Task<IList<Training>> GetCharacterTrainingAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<GetCharacterTrainingResponse>($"characters/{id}/training", accessToken, token)).Training;
    }
}
