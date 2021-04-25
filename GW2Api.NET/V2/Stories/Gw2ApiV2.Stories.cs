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

        public Task<Page<IList<BackstoryAnswer>>> GetBackstoryAnswersAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<BackstoryAnswer>>(
                "backstory/answers",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllBackstoryQuestionIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("backstory/questions", token);

        public Task<BackstoryQuestion> GetBackstoryQuestionAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<BackstoryQuestion>(
                $"backstory/questions/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<BackstoryQuestion>> GetBackstoryQuestionsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<BackstoryQuestion>>(
                "backstory/questions",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<BackstoryQuestion>> GetAllBackstoryQuestionsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<BackstoryQuestion>>(
                "backstory/questions",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<BackstoryQuestion>>> GetBackstoryQuestionsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<BackstoryQuestion>>(
                "backstory/questions",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllStoryIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("stories", token);

        public Task<Story> GetStoryAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Story>(
                $"stories/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Story>> GetStoriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Story>>(
                "stories",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Story>> GetAllStoriesAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Story>>(
                "stories",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Story>>> GetStoriesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Story>>(
                "stories",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<Guid>> GetAllStorySeasonIdsAsync(CancellationToken token = default)
            => GetAsync<IList<Guid>>("stories/seasons", token);

        public Task<StorySeason> GetStorySeasonAsync(Guid id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<StorySeason>(
                $"stories/seasons/{id.ToUrlParam()}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<StorySeason>> GetStorySeasonsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<StorySeason>>(
                "stories/seasons",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<StorySeason>> GetAllStorySeasonsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<StorySeason>>(
                "stories/seasons",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<StorySeason>>> GetStorySeasonsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<StorySeason>>(
                "stories/seasons",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );

        public Task<IList<int>> GetAllQuestIdsAsync(CancellationToken token = default)
            => GetAsync<IList<int>>("quests", token);

        public Task<Quest> GetQuestAsync(int id, CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<Quest>(
                $"quests/{id}",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<IList<Quest>> GetQuestsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default)
        {
            if (ids is null)
                throw new ArgumentNullException(nameof(ids));

            return GetAsync<IList<Quest>>(
                "quests",
                new Dictionary<string, string>
                {
                    { "ids", ids.ToUrlParam() },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );
        }

        public Task<IList<Quest>> GetAllQuestsAsync(CultureInfo lang = null, CancellationToken token = default)
            => GetAsync<IList<Quest>>(
                "quests",
                new Dictionary<string, string>
                {
                    { "ids", "all" },
                    { "lang", lang.ToUrlParam() }
                },
                token
            );

        public Task<Page<IList<Quest>>> GetQuestsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default)
            => GetPageAsync<IList<Quest>>(
                "quests",
                new Dictionary<string, string>
                {
                    { "lang", lang.ToUrlParam() }
                }.ConfigurePage(page, pageSize),
                token
            );
    }
}
