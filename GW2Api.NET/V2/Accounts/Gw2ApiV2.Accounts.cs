using GW2Api.NET.V2.Accounts.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        private static readonly string _accountResource = "account";

        public Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default)
            => GetAuthenticatedAsync<Account>(_accountResource, accessToken, token);
    }
}
