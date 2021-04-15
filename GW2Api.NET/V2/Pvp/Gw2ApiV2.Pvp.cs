using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Pvp.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<PvpStats> GetPvpStatsAsync(string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<PvpStats>("pvp/stats", accessToken, token);

        public Task<IList<Guid>> GetAllPvpGameIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<IList<Guid>>("pvp/games", accessToken, token);

        public Task<PvpGame> GetPvpGameAsync(Guid id, string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<PvpGame>(
                $"pvp/games/{id.ToUrlParam()}",
                accessToken,
                token
            );

        public Task<IList<PvpGame>> GetPvpGamesAsync(IEnumerable<Guid> ids, string accessToken = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetWithAuthAsync<IList<PvpGame>>(
                "pvp/games",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                accessToken,
                token
            );
        }

        public Task<IList<PvpGame>> Get10MostRecentPvpGamesAsync(string accessToken = null, CancellationToken token = default)
            => GetWithAuthAsync<IList<PvpGame>>(
                "pvp/games",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                accessToken,
                token
            );
    }
}
