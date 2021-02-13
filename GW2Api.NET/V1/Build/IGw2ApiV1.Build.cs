﻿using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<Build> GetBuildAsync();
        Task<Build> GetBuildAsync(CancellationToken token);
    }
}
