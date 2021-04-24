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

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllStoryIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllStoryIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetStoryAsync_TestData()
            => new List<object[]>
            {
                new object[] { 3 },
                new [] { (null, "My Story"), ("es", "Mi historia") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetStoryAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetStoryAsync_ValidId_ReturnsThatStory(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetStoryAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetStoriesAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetStoriesAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetStoriesAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 3, 10, 11} },
                new [] {
                    (null, new List<string> { "My Story", "The Elder Dragon Zhaitan", "1. Gates of Maguuma" }.AsEnumerable()),
                    ("es", new List<string> { "Mi historia", "El dragón anciano Zhaitan", "1. A las puertas de Maguuma" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetStoriesAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetStoriesAsync_ValidIds_ReturnsThoseStories(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetStoriesAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllStoriesAsync_AnyParams_ReturnsAllStories(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllStoriesAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetStoriesAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetStoriesAsync(page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllStorySeasonIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllStorySeasonIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetStorySeasonAsync_TestData()
            => new List<object[]>
            {
                new object[] { Guid.Parse("09766A86-D88D-4DF2-9385-259E9A8CA583") },
                new [] { (null, "Living World Season 3"), ("es", "Mundo viviente, 3.ª temporada") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetStorySeasonAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetStorySeasonAsync_ValidId_ReturnsThatStorySeason(Guid id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetStorySeasonAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetStorySeasonsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetStorySeasonsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetStorySeasonsAsync_TestData()
            => new List<object[]>
            {
                new [] {
                    new List<Guid> {
                        Guid.Parse("09766A86-D88D-4DF2-9385-259E9A8CA583"),
                        Guid.Parse("EDCAE800-302A-4D9B-8331-3CC769ADA0B3"),
                        Guid.Parse("002C2D90-69B5-41A2-A422-8DB6F2EFC53E"),
                    }
                },
                new [] {
                    (null, new List<string> { "Living World Season 3", "The Icebrood Saga", "Scarlet's War" }.AsEnumerable()),
                    ("es", new List<string> { "Mundo viviente, 3.ª temporada", "Sangre y Hielo", "La guerra de Scarlet" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetStorySeasonsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetStorySeasonsAsync_ValidIds_ReturnsThoseStorySeasons(IEnumerable<Guid> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetStorySeasonsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllStorySeasonsAsync_AnyParams_ReturnsAllStorySeasons(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllStorySeasonsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetStorySeasonsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetStorySeasonsAsync(page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllQuestIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllQuestIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetQuestAsync_TestData()
            => new List<object[]>
            {
                new object[] { 15 },
                new [] { (null, "Explosive Intellect"), ("es", "Intelecto explosivo") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetQuestAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetQuestAsync_ValidId_ReturnsThatQuest(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetQuestAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetQuestsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetQuestsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetQuestsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 15, 16, 17 } },
                new [] {
                    (null, new List<string> { "Explosive Intellect", "Golem Positioning System", "In Snaff's Footsteps" }.AsEnumerable()),
                    ("es", new List<string> { "Intelecto explosivo", "Sistema de posicionamiento gólem", "Tras los pasos de Snaff" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetQuestsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetQuestsAsync_ValidIds_ReturnsThoseQuests(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetQuestsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllQuestsAsync_AnyParams_ReturnsAllQuests(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllQuestsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetQuestsAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetQuestsAsync(page: 1, pageSize: 1, lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
