using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Accounts.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        private static readonly string _accountResource = "account";
        private static readonly string _accountAchievementsResource = "account/achievements";
        private static readonly string _accountBankResource = "account/bank";
        private static readonly string _accountDailyCraftingResource = "account/dailycrafting";
        private static readonly string _accountDungeonsResource = "account/dungeons";

        public Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<Account>(_accountResource, accessToken, token);

        public Task<IEnumerable<AccountAchievement>> GetAllAccountAchievementsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IEnumerable<AccountAchievement>>(_accountAchievementsResource, accessToken, token);

        public Task<AccountAchievement> GetAccountAchievementAsync(int id, string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<AccountAchievement>(
                _accountAchievementsResource,
                new Dictionary<string, string>
                {
                    { "id", id.ToString() }
                },
                accessToken,
                token
            );

        public Task<IEnumerable<AccountAchievement>> GetAccountAchievementsAsync(IEnumerable<int> ids, string accessToken = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAuthenticatedAsync<IEnumerable<AccountAchievement>>(
                _accountAchievementsResource,
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                },
                accessToken,
                token
            );
        }

        public Task<IEnumerable<BankSlot>> GetAccountBankAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IEnumerable<BankSlot>>(_accountBankResource, accessToken, token);

        public Task<IEnumerable<string>> GetAccountDailyCraftingAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IEnumerable<string>>(_accountDailyCraftingResource, accessToken, token);

        public Task<IEnumerable<string>> GetAccountDungeonsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IEnumerable<string>>(_accountDungeonsResource, accessToken, token);
    }
}
