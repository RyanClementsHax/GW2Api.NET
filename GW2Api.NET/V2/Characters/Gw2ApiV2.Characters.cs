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
    }
}
