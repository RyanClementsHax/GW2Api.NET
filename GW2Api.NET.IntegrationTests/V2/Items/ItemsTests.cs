using GW2Api.NET.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V2.Items
{
    [TestClass, TestCategory("Large"), TestCategory("V2"), TestCategory("V2 Items")]
    public class ItemsTests
    {
        private IGw2ApiV2 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV2(new HttpClient());

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFinisherIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetFinisherIdsAsync(cts?.Token ?? default);

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetFinisherAsync_TestData()
            => new List<object[]>
            {
                new object[] { 10 },
                new [] { (null, "Cow Finisher"), ("es", "Remate de vaca") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetFinisherAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetFinisherAsync_ValidId_ReturnsThatFinisher(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetFinisherAsync(id, lang, cts?.Token ?? default);

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFinishersAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetFinishersAsync(ids: null, lang, cts?.Token ?? default);
        }

        public static IEnumerable<object[]> GetFinishersAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 10, 20, 30 } },
                new [] {
                    (null, new List<string> { "Cow Finisher", "Gift Finisher", "WvW Golden Dolyak Finisher" }.AsEnumerable()),
                    ("es", new List<string> { "Remate de vaca", "Remate de regalo", "Remate de dolyak dorado WvW" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetFinishersAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetFinishersAsync_ValidIds_ReturnsThoseFinishers(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetFinishersAsync(ids, lang, cts?.Token ?? default);

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFinishersAsync_ValidId_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetFinishersAsync(lang: lang, token: cts?.Token ?? default);

            Assert.IsTrue(result.Data.Any());
        }
    }
}
