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
        private static readonly string _accountLuckResource = "account/luck";
        private static readonly string _accountMailCarriersResource = "account/mailcarriers";
        private static readonly string _accountMapChestsResource = "account/mapchests";
        private static readonly string _accountMasteriesResource = "account/masteries";
        private static readonly string _accountMasteryPointsResource = "account/mastery/points";
        private static readonly string _accountMaterialsResource = "account/materials";
        private static readonly string _accountMinisResource = "account/minis";
        private static readonly string _accountMountsSkinsResource = "account/mounts/skins";

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

        public Task<IList<ConsumedLuck>> GetAccountLuckAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<ConsumedLuck>>(_accountLuckResource, accessToken, token);

        public Task<IList<int>> GetAccountMailCarrierIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>(_accountMailCarriersResource, accessToken, token);

        public Task<IList<string>> GetAccountMapChestIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>(_accountMapChestsResource, accessToken, token);

        public Task<IList<AccountMastery>> GetAccountMasteriesAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<AccountMastery>>(_accountMasteriesResource, accessToken, token);

        public Task<AccountMasteryPointSummary> GetAccountMasteryPointSummaryAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<AccountMasteryPointSummary>(_accountMasteryPointsResource, accessToken, token);

        public Task<IList<MaterialSummary>> GetAccountMaterialSummariesAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<MaterialSummary>>(_accountMaterialsResource, accessToken, token);

        public Task<IList<int>> GetAccountMinisIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>(_accountMinisResource, accessToken, token);

        public Task<IList<int>> GetAccountMountSkinIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>(_accountMountsSkinsResource, accessToken, token);
    }
}
