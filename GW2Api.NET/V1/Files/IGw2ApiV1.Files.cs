using GW2Api.NET.V1.Files.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial interface IGw2ApiV1
    {
        Task<IDictionary<string, File>> GetAllFilesAsync(CancellationToken token = default);
    }
}
