using GW2Api.NET.V2.Stories.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace GW2Api.NET.V2
{
    public partial interface IGw2ApiV2
    {
        Task<IList<string>> GetAllBackstoryAnswerIdsAsync(CancellationToken token = default);
        Task<BackstoryAnswer> GetBackstoryAnswerAsync(string id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<BackstoryAnswer>> GetBackstoryAnswersAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<BackstoryAnswer>> GetAllBackstoryAnswersAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<BackstoryAnswer>>> GetBackstoryAnswersAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllBackstoryQuestionIdsAsync(CancellationToken token = default);
        Task<BackstoryQuestion> GetBackstoryQuestionAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<BackstoryQuestion>> GetBackstoryQuestionsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<BackstoryQuestion>> GetAllBackstoryQuestionsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<BackstoryQuestion>>> GetBackstoryQuestionsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllStoryIdsAsync(CancellationToken token = default);
        Task<Story> GetStoryAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Story>> GetStoriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Story>> GetAllStoriesAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Story>>> GetStoriesAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Guid>> GetAllStorySeasonIdsAsync(CancellationToken token = default);
        Task<StorySeason> GetStorySeasonAsync(Guid id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<StorySeason>> GetStorySeasonsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<StorySeason>> GetAllStorySeasonsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<StorySeason>>> GetStorySeasonsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<int>> GetAllQuestIdsAsync(CancellationToken token = default);
        Task<Quest> GetQuestAsync(int id, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Quest>> GetQuestsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
        Task<IList<Quest>> GetAllQuestsAsync(CultureInfo lang = null, CancellationToken token = default);
        Task<Page<IList<Quest>>> GetQuestsAsync(int page = 1, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
    }
}
