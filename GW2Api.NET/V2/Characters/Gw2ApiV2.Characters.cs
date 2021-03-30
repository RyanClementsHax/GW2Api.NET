using GW2Api.NET.V2.Characters.Dto;
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
    }
}
