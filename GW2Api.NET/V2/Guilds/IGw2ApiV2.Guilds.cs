﻿using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Guilds.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<Guild> GetGuildAsync(Guid id, CancellationToken token = default);
        Task<IList<int>> GetAllEmblemBackgroundIdsAsync(CancellationToken token = default);
        Task<EmblemLayer> GetEmblemBackgroundAsync(int id, CancellationToken token = default);
        Task<IList<EmblemLayer>> GetEmblemBackgroundsAsync(IEnumerable<int> ids, CancellationToken token = default);
        Task<IList<EmblemLayer>> GetAllEmblemBackgroundsAsync(CancellationToken token = default);
        Task<Page<IList<EmblemLayer>>> GetEmblemBackgroundsAsync(int page = 1, int pageSize = -1, CancellationToken token = default);
        Task<IList<int>> GetAllEmblemForegroundIdsAsync(CancellationToken token = default);
        Task<EmblemLayer> GetEmblemForegroundAsync(int id, CancellationToken token = default);
        Task<IList<EmblemLayer>> GetEmblemForegroundsAsync(IEnumerable<int> ids, CancellationToken token = default);
        Task<IList<EmblemLayer>> GetAllEmblemForegroundsAsync(CancellationToken token = default);
        Task<Page<IList<EmblemLayer>>> GetEmblemForegroundsAsync(int page = 1, int pageSize = -1, CancellationToken token = default);
        Task<IList<string>> GetAllGuildPermissionIdsAsync(CancellationToken token = default);
        Task<GuildPermission> GetGuildPermissionAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<GuildPermission>> GetGuildPermissionsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<GuildPermission>> GetAllGuildPermissionsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<GuildPermission>>> GetGuildPermissionsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Guid>> SearchGuildsByNameAsync(string name, CancellationToken token);
        Task<IList<int>> GetAllGuildUpgradeIdsAsync(CancellationToken token = default);
        Task<GuildUpgrade> GetGuildUpgradeAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<GuildUpgrade>> GetGuildUpgradesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<GuildUpgrade>> GetAllGuildUpgradesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<GuildUpgrade>>> GetGuildUpgradesAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}