using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<int> GetBuildAsync(CancellationToken token = default);
    }
}
