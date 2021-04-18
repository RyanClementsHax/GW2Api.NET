using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.GameMechanics.Dto.Legends;
using GW2Api.NET.V2.GameMechanics.Dto.Masteries;
using GW2Api.NET.V2.GameMechanics.Dto.Mounts;
using GW2Api.NET.V2.GameMechanics.Dto.Outfits;
using GW2Api.NET.V2.GameMechanics.Dto.Pets;
using GW2Api.NET.V2.GameMechanics.Dto.Professions;
using GW2Api.NET.V2.GameMechanics.Dto.Races;
using GW2Api.NET.V2.GameMechanics.Dto.Skills;
using GW2Api.NET.V2.GameMechanics.Dto.Specializations;
using GW2Api.NET.V2.GameMechanics.Dto.Traits;
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

        public Task<IList<int>> GetAllOutfitIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("outfits", token);

        public Task<Outfit> GetOutfitAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Outfit>(
                $"outfits/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Outfit>> GetOutfitsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Outfit>>(
                "outfits",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Outfit>> GetAllOutfitsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Outfit>>(
                "outfits",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Outfit>>> GetOutfitsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Outfit>>(
                "outfits",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllPetIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("pets", token);

        public Task<Pet> GetPetAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Pet>(
                $"pets/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Pet>> GetPetsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Pet>>(
                "pets",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Pet>> GetAllPetsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Pet>>(
                "pets",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Pet>>> GetPetsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Pet>>(
                "pets",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllProfessionIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("professions", token);

        public Task<ProfessionDetails> GetProfessionAsync(string id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<ProfessionDetails>(
                $"professions/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<ProfessionDetails>> GetProfessionsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<ProfessionDetails>>(
                "professions",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<ProfessionDetails>> GetAllProfessionsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<ProfessionDetails>>(
                "professions",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<ProfessionDetails>>> GetProfessionsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<ProfessionDetails>>(
                "professions",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllRaceIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("races", token);

        public Task<RaceDetails> GetRaceAsync(string id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<RaceDetails>(
                $"races/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<RaceDetails>> GetRacesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<RaceDetails>>(
                "races",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<RaceDetails>> GetAllRacesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<RaceDetails>>(
                "races",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<RaceDetails>>> GetRacesAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<RaceDetails>>(
                "races",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllSpecializationIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("specializations", token);

        public Task<Specialization> GetSpecializationAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Specialization>(
                $"specializations/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Specialization>> GetSpecializationsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Specialization>>(
                "specializations",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Specialization>> GetAllSpecializationsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Specialization>>(
                "specializations",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Specialization>>> GetSpecializationsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Specialization>>(
                "specializations",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllSkillIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("skills", token);

        public Task<Skill> GetSkillAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Skill>(
                $"skills/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Skill>> GetSkillsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Skill>>(
                "skills",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Skill>> GetAllSkillsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Skill>>(
                "skills",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Skill>>> GetSkillsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Skill>>(
                "skills",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllTraitIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("traits", token);

        public Task<Trait> GetTraitAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Trait>(
                $"traits/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Trait>> GetTraitsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Trait>>(
                "traits",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Trait>> GetAllTraitsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Trait>>(
                "traits",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Trait>>> GetTraitsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Trait>>(
                "traits",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<string>> GetAllLegendIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("legends", token);

        public Task<Legend> GetLegendAsync(string id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Legend>(
                $"legends/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Legend>> GetLegendsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Legend>>(
                "legends",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Legend>> GetAllLegendsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Legend>>(
                "legends",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Legend>>> GetLegendsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Legend>>(
                "legends",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
