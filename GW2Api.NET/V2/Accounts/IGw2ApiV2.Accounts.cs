using GW2Api.NET.V2.Accounts.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default);
    }
}
