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
            => (await GetAuthenticatedAsync<CharacterBackstoryResponse>($"characters/{id}/backstory", accessToken, token)).Backstory;

        public Task<CharacterCore> GetCharacterCoreAsync(string id, string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<CharacterCore>($"characters/{id}/core", accessToken, token);

        public async Task<IList<CraftingDiscipline>> GetCharacterCraftingAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<CharacterCraftingResponse>($"characters/{id}/crafting", accessToken, token)).Crafting;

        public async Task<IList<Equipment>> GetCharacterEquipmentAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<CharacterEqipmentResponse>($"characters/{id}/equipment", accessToken, token)).Equipment;

        public Task<IList<string>> GetCharacterHeroPointsAsync(string id, string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>($"characters/{id}/heropoints", accessToken, token);

        public async Task<IList<Bag>> GetCharacterInventoryAsync(string id, string accessToken = null, CancellationToken token = default)
            => (await GetAuthenticatedAsync<CharacterInventoryResponse>($"characters/{id}/inventory", accessToken, token)).Bags;
    }
}
