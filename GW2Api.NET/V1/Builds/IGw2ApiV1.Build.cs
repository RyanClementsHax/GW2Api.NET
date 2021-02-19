using GW2Api.NET.V1.Builds.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<Build> GetBuildAsync(CancellationToken token = default);
    }
}
