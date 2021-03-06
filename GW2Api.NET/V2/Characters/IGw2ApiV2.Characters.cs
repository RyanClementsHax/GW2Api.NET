﻿using GW2Api.NET.V2.Characters.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<string>> GetAllCharacterIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<Character> GetCharacterAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<IList<Character>> GetCharactersAsync(IEnumerable<string> ids, string accessToken = null, CancellationToken token = default);
        Task<IList<Character>> GetAllCharactersAsync(string accessToken = null, CancellationToken token = default);
        Task<Page<IList<Character>>> GetCharactersAsync(int page = 0, int pageSize = -1, string accessToken = null, CancellationToken token = default);
        Task<IList<string>> GetCharacterBackstoryAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<CharacterCore> GetCharacterCoreAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<IList<CraftingDiscipline>> GetCharacterCraftingAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<IList<Equipment>> GetCharacterEquipmentAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<IList<string>> GetCharacterHeroPointsAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<IList<Bag>> GetCharacterInventoryAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<IList<int>> GetCharacterRecipesAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<Sab> GetCharacterSabAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<Skills> GetCharacterSkillsAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<Specializations> GetCharacterSpecializationsAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<IList<CharacterTraining>> GetCharacterTrainingAsync(string id, string accessToken = null, CancellationToken token = default);
    }
}
