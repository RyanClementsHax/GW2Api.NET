using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.GameMechanics.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<int>> GetAllMasteryIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("masteries", token);

        public Task<Mastery> GetMasteryAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Mastery>(
                $"masteries/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Mastery>> GetMasteriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Mastery>>(
                "masteries",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Mastery>> GetAllMasteriesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Mastery>>(
                "masteries",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<int>> GetAllMountSkinIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("mounts/skins", token);

        public Task<MountSkin> GetMountSkinAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<MountSkin>(
                $"mounts/skins/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<MountSkin>> GetMountSkinsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<MountSkin>>(
                "mounts/skins",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<MountSkin>> GetAllMountSkinsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<MountSkin>>(
                "mounts/skins",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<MountSkin>>> GetMountSkinsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<MountSkin>>(
                "mounts/skins",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllMountTypeIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("mounts/types", token);

        public Task<MountType> GetMountTypeAsync(string id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<MountType>(
                $"mounts/types/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<MountType>> GetMountTypesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<MountType>>(
                "mounts/types",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<MountType>> GetAllMountTypesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<MountType>>(
                "mounts/types",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<MountType>>> GetMountTypesAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<MountType>>(
                "mounts/types",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
