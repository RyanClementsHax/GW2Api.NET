using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _buildResource = "build.json";

        public Task<Build> GetBuildAsync() => GetAsync<Build>(_buildResource);

        public Task<Build> GetBuildAsync(CancellationToken token) => GetAsync<Build>(_buildResource, token);
    }
}
