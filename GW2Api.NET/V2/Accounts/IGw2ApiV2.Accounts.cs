using GW2Api.NET.V2.Accounts.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<AccountAchievement>> GetAllAccountAchievementsAsync(string accessToken = null, CancellationToken token = default);
        Task<AccountAchievement> GetAccountAchievementAsync(int id, string accessToken = null, CancellationToken token = default);
        Task<IList<AccountAchievement>> GetAccountAchievementsAsync(IEnumerable<int> ids, string accessToken = null, CancellationToken token = default);
        Task<IList<BankSlot>> GetAccountBankAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<string>> GetAccountDailyCraftingIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<string>> GetAccountDungeonIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<int>> GetAccountDyeIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<AccountFinisher>> GetAccountFinishersAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<int>> GetAccountGliderIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<int>> GetAccountHomeCatIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<string>> GetAccountHomeNodeIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<SharedInventorySlot>> GetAccountSharedInventorySlotsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<ConsumedLuck>> GetAccountLuckAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<int>> GetAccountMailCarrierIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<string>> GetAccountMapChestIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IList<AccountMastery>> GetAccountMasteriesAsync(string accessToken = null, CancellationToken token = default);
    }
}
