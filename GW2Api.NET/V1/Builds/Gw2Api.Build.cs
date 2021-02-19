using GW2Api.NET.V1.Builds;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _buildResource = "build.json";

        public Task<Build> GetBuildAsync(CancellationToken token = default)
            => GetAsync<Build>(_buildResource, token);
    }
}
