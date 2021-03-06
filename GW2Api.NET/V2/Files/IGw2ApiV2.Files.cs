﻿using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Files.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<string>> GetAllFileIdsAsync(CancellationToken token = default);
        Task<File> GetFileAsync(string id, CancellationToken token = default);
        Task<IList<File>> GetFilesAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<File>> GetAllFilesAsync(CancellationToken token = default);
        Task<Page<IList<File>>> GetFilesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
        Task<IList<string>> GetAllQuagganIdsAsync(CancellationToken token = default);
        Task<Quaggan> GetQuagganAsync(string id, CancellationToken token = default);
        Task<IList<Quaggan>> GetQuaggansAsync(IEnumerable<string> ids, CancellationToken token = default);
        Task<IList<Quaggan>> GetAllQuaggansAsync(CancellationToken token = default);
        Task<Page<IList<Quaggan>>> GetQuaggansAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
    }
}
