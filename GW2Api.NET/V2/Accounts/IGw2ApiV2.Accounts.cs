using GW2Api.NET.V2.Accounts.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<AccountAchievement>> GetAllAccountAchievementsAsync(string accessToken = null, CancellationToken token = default);
        Task<AccountAchievement> GetAccountAchievementAsync(int id, string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<AccountAchievement>> GetAccountAchievementsAsync(IEnumerable<int> ids, string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<BankSlot>> GetAccountBankAsync(string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<string>> GetAccountDailyCraftingIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<string>> GetAccountDungeonIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<int>> GetAccountDyeIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<AccountFinisher>> GetAccountFinishersAsync(string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<int>> GetAccountGliderIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<int>> GetAccountHomeCatIdsAsync(string accessToken = null, CancellationToken token = default);
        Task<IEnumerable<string>> GetAccountHomeNodeIdsAsync(string accessToken = null, CancellationToken token = default);
    }
}
