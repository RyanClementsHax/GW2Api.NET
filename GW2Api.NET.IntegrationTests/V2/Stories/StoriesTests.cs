using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Stories
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Stories")]
    public class StoriesTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllBackstoryAnswerIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllBackstoryAnswerIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetBackstoryAnswerAsync_TestData()
            => new List<object[]>
            {
                new object[] { "7-54" },
                new [] { (null, "Dignity"), ("es", "Dignidad") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetBackstoryAnswerAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetBackstoryAnswerAsync_ValidId_ReturnsThatBackstoryAnswer(string id, (CultureInfo, string) langTitleTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, title) = langTitleTuple;

            var result = await _api.GetBackstoryAnswerAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(title, result.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetBackstoryAnswersAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetBackstoryAnswersAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetBackstoryAnswersAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<string> { "7-54", "188-189", "22-109" } },
                new [] {
                    (null, new List<string> { "Dignity", "Fanged Dread", "Dead Sister" }.AsEnumerable()),
                    ("es", new List<string> { "Dignidad", "Terror acolmillado", "Hermana muerta" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetBackstoryAnswersAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetBackstoryAnswersAsync_ValidIds_ReturnsThoseBackstoryAnswers(IEnumerable<string> ids, (CultureInfo, IEnumerable<string>) langTitlesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, titles) = langTitlesTuple;

            var result = await _api.GetBackstoryAnswersAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(titles.ToList(), result.Select(x => x.Title).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllBackstoryAnswersAsync_AnyParams_ReturnsAllBackstoryAnswers(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllBackstoryAnswersAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetBackstoryAnswersAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetBackstoryAnswersAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllBackstoryQuestionIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllBackstoryQuestionIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetBackstoryQuestionAsync_TestData()
            => new List<object[]>
            {
                new object[] { 7 },
                new [] { (null, "My Personality"), ("es", "Mi personalidad") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetBackstoryQuestionAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetBackstoryQuestionAsync_ValidId_ReturnsThatBackstoryQuestion(int id, (CultureInfo, string) langTitleTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, title) = langTitleTuple;

            var result = await _api.GetBackstoryQuestionAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(title, result.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetBackstoryQuestionsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetBackstoryQuestionsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetBackstoryQuestionsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 7, 10, 181 } },
                new [] {
                    (null, new List<string> { "My Personality", "My college", "My Most Useful Tool." }.AsEnumerable()),
                    ("es", new List<string> { "Mi personalidad", "Mi instituto", "Mi herramienta más útil" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetBackstoryQuestionsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetBackstoryQuestionsAsync_ValidIds_ReturnsThoseBackstoryQuestions(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langTitlesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, titles) = langTitlesTuple;

            var result = await _api.GetBackstoryQuestionsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(titles.ToList(), result.Select(x => x.Title).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllBackstoryQuestionsAsync_AnyParams_ReturnsAllBackstoryQuestions(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllBackstoryQuestionsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetBackstoryQuestionsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetBackstoryQuestionsAsync(page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
