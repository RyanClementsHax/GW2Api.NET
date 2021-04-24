using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Files.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {

        public Task<IList<string>> GetAllFileIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("files", token);

        public Task<File> GetFileAsync(string id, CancellationToken token = default)
            => GetAsync<File>($"files/{id}", token);

        public Task<IList<File>> GetFilesAsync(IEnumerable<string> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<File>>(
                "files",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<File>> GetAllFilesAsync(CancellationToken token = default)
            => GetAsync<IList<File>>(
                "files",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<File>>> GetFilesAsync(int page = 1, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<File>>(
                "files",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );
    }
}
