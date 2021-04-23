using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Guilds.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<Guild> GetGuildAsync(Guid id, CancellationToken token = default)
            => GetAsync<Guild>($"guild/{id}", token);

        public Task<IList<int>> GetAllEmblemBackgroundIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("emblem/backgrounds", token);

        public Task<EmblemLayer> GetEmblemBackgroundAsync(int id, CancellationToken token = default)
            => GetAsync<EmblemLayer>($"emblem/backgrounds/{id}", token);

        public Task<IList<EmblemLayer>> GetEmblemBackgroundsAsync(IEnumerable<int> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<EmblemLayer>>(
                "emblem/backgrounds",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<EmblemLayer>> GetAllEmblemBackgroundsAsync(CancellationToken token = default)
            => GetAsync<IList<EmblemLayer>>(
                "emblem/backgrounds",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<EmblemLayer>>> GetEmblemBackgroundsAsync(int page = 1, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<EmblemLayer>>(
                "emblem/backgrounds",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllEmblemForegroundIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("emblem/foregrounds", token);

        public Task<EmblemLayer> GetEmblemForegroundAsync(int id, CancellationToken token = default)
            => GetAsync<EmblemLayer>($"emblem/foregrounds/{id}", token);

        public Task<IList<EmblemLayer>> GetEmblemForegroundsAsync(IEnumerable<int> ids, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<EmblemLayer>>(
                "emblem/foregrounds",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<EmblemLayer>> GetAllEmblemForegroundsAsync(CancellationToken token = default)
            => GetAsync<IList<EmblemLayer>>(
                "emblem/foregrounds",
                new Dictionary<string, string>
                {
                    { "ids", "all" }
                },
                token
            );

        public Task<Page<IList<EmblemLayer>>> GetEmblemForegroundsAsync(int page = 1, int pageSize = -1, CancellationToken token = default)
            => GetPageAsync<IList<EmblemLayer>>(
                "emblem/foregrounds",
                new Dictionary<string, string> { }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllGuildPermissionIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("guild/permissions", token);

        public Task<GuildPermission> GetGuildPermissionAsync(string id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<GuildPermission>(
                $"guild/permissions/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<GuildPermission>> GetGuildPermissionsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<GuildPermission>>(
                "guild/permissions",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<GuildPermission>> GetAllGuildPermissionsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<GuildPermission>>(
                "guild/permissions",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<GuildPermission>>> GetGuildPermissionsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<GuildPermission>>(
                "guild/permissions",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
