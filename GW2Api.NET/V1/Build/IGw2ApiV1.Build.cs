using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<Build.Build> GetBuildAsync(CancellationToken token = default);
    }
}
