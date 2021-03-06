﻿using GW2Api.NET.V1.Files.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V1
{
    public partial class Gw2ApiV1
    {
        private static readonly string _filesResource = "files.json";

        public async Task<IDictionary<string, File>> GetAllFilesAsync(CancellationToken token = default)
            => (await GetAsync<IDictionary<string, File>>(_filesResource, token))
                .ToDictionary(
                    x => x.Key,
                    x => x.Value with
                    {
                        Name = x.Key
                    }
                );
    }
}
