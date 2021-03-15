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
        public Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<Account>("account", accessToken, token);

        private static readonly string _accountAchievementsResource = "account/achievements";

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
            => GetAuthenticatedAsync<IList<BankSlot>>("account/bank", accessToken, token);

        public Task<IList<string>> GetAccountDailyCraftingIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>("account/dailycrafting", accessToken, token);

        public Task<IList<string>> GetAccountDungeonIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>("account/dungeons", accessToken, token);
        
        public Task<IList<int>> GetAccountDyeIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/dyes", accessToken, token);

        public Task<IList<AccountFinisher>> GetAccountFinishersAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<AccountFinisher>>("account/finishers", accessToken, token);

        public Task<IList<int>> GetAccountGliderIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/gliders", accessToken, token);

        public Task<IList<int>> GetAccountHomeCatIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/home/cats", accessToken, token);

        public Task<IList<string>> GetAccountHomeNodeIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>("account/home/nodes", accessToken, token);

        public Task<IList<SharedInventorySlot>> GetAccountSharedInventorySlotsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<SharedInventorySlot>>("account/inventory", accessToken, token);

        public Task<IList<ConsumedLuck>> GetAccountLuckAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<ConsumedLuck>>("account/luck", accessToken, token);

        public Task<IList<int>> GetAccountMailCarrierIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/mailcarriers", accessToken, token);

        public Task<IList<string>> GetAccountMapChestIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>("account/mapchests", accessToken, token);

        public Task<IList<AccountMastery>> GetAccountMasteriesAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<AccountMastery>>("account/masteries", accessToken, token);

        public Task<AccountMasteryPointSummary> GetAccountMasteryPointSummaryAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<AccountMasteryPointSummary>("account/mastery/points", accessToken, token);

        public Task<IList<MaterialSummary>> GetAccountMaterialSummariesAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<MaterialSummary>>("account/materials", accessToken, token);

        public Task<IList<int>> GetAccountMinisIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/minis", accessToken, token);

        public Task<IList<int>> GetAccountMountSkinIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/mounts/skins", accessToken, token);

        public Task<IList<string>> GetAccountMountTypesAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>("account/mounts/types", accessToken, token);

        public Task<IList<int>> GetAccountNoveltyIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/novelties", accessToken, token);

        public Task<IList<int>> GetAccountOutfitIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/outfits", accessToken, token);

        public Task<IList<int>> GetAccountPvpHeroIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/pvp/heroes", accessToken, token);

        public Task<IList<string>> GetAccountRaidIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<string>>("account/raids", accessToken, token);

        public Task<IList<int>> GetAccountRecipeIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/recipes", accessToken, token);

        public Task<IList<int>> GetAccountSkinIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/skins", accessToken, token);

        public Task<IList<int>> GetAccountTitleIdsAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<IList<int>>("account/titles", accessToken, token);
    }
}
