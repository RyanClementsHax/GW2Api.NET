using GW2Api.NET.Helpers;
using GW2Api.NET.V2.Common;
using GW2Api.NET.V2.Stories.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.V2
{
    public partial class Gw2ApiV2
    {
        public Task<IList<string>> GetAllBackstoryAnswerIdsAsync(CancellationToken token = default)
            => GetAsync<IList<string>>("backstory/answers", token);

        public Task<BackstoryAnswer> GetBackstoryAnswerAsync(string id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<BackstoryAnswer>(
                $"backstory/answers/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<BackstoryAnswer>> GetBackstoryAnswersAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<BackstoryAnswer>>(
                "backstory/answers",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<BackstoryAnswer>> GetAllBackstoryAnswersAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<BackstoryAnswer>>(
                "backstory/answers",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<BackstoryAnswer>>> GetBackstoryAnswersAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<BackstoryAnswer>>(
                "backstory/answers",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
