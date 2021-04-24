using GW2Api.NET.V2.Builds.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public async Task<int> GetBuildAsync(CancellationToken token = default)
            => (await GetAsync<GetBuildResponse>("build", token)).Id;
    }
}
