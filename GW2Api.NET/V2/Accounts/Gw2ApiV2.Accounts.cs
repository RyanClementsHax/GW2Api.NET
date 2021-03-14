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
        private static readonly string _accountDyesResource = "account/dyes";
        private static readonly string _accountFinishersResource = "account/finishers";
        private static readonly string _accountGlidersResource = "account/gliders";
        private static readonly string _accountHomeCatsResource = "account/home/cats";
        private static readonly string _accountHomeNodesResource = "account/home/nodes";
        private static readonly string _accountInventoryResource = "account/inventory";

        public Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<Account>(_accountResource, accessToken, token);

        public Task<IList<AccountAchievement>> GetAllAccountAchievementsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<AccountAchievement>>(_accountAchievementsResource, accessToken, token);

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

        public Task<IList<AccountAchievement>> GetAccountAchievementsAsync(IEnumerable<int> ids, string accessToken = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAuthenticatedAsync<IList<AccountAchievement>>(
                _accountAchievementsResource,
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                },
                accessToken,
                token
            );
        }

        public Task<IList<BankSlot>> GetAccountBankAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<BankSlot>>(_accountBankResource, accessToken, token);

        public Task<IList<string>> GetAccountDailyCraftingIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>(_accountDailyCraftingResource, accessToken, token);

        public Task<IList<string>> GetAccountDungeonIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>(_accountDungeonsResource, accessToken, token);
        
        public Task<IList<int>> GetAccountDyeIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>(_accountDyesResource, accessToken, token);

        public Task<IList<AccountFinisher>> GetAccountFinishersAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<AccountFinisher>>(_accountFinishersResource, accessToken, token);

        public Task<IList<int>> GetAccountGliderIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>(_accountGlidersResource, accessToken, token);

        public Task<IList<int>> GetAccountHomeCatIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>(_accountHomeCatsResource, accessToken, token);

        public Task<IList<string>> GetAccountHomeNodeIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>(_accountHomeNodesResource, accessToken, token);

        public Task<IList<SharedInventorySlot>> GetAccountSharedInventorySlotsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<SharedInventorySlot>>(_accountInventoryResource, accessToken, token);
    }
}
