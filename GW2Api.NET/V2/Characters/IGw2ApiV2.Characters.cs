﻿using GW2Api.NET.V2.Characters.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<string>> GetCharacterIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<Character> GetCharacterAsync(string id, string accessToken = null, CancellationToken token = default);
        Task<IList<Character>> GetCharactersAsync(IEnumerable<string> ids, string accessToken = null, CancellationToken token = default);
    }
}