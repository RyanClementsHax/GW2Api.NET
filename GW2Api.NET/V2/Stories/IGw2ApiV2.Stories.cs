using GW2Api.NET.V2.Stories.Dto;
using GW2Api.NET.V2.Common;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

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
    }
}
