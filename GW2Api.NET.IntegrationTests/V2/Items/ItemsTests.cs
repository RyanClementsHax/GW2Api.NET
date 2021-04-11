using GW2Api.NET.V2;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Armor;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Back;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Bag;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Consumable;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Container;
using GW2Api.NET.V2.Items.Dto.ItemTypes.CraftingMaterial;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Gathering;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Gizmo;
using GW2Api.NET.V2.Items.Dto.ItemTypes.MiniPet;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Tool;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Trinket;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Trophy;
using GW2Api.NET.V2.Items.Dto.ItemTypes.UpgradeComponent;
using GW2Api.NET.V2.Items.Dto.ItemTypes.Weapon;
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

            var result = await _api.GetFinisherIdsAsync(cts.GetTokenOrDefault());

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

            var result = await _api.GetFinisherAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFinishersAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetFinishersAsync(ids: null, lang, cts.GetTokenOrDefault());
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

            var result = await _api.GetFinishersAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFinishersAsync_ValidId_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetFinishersAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllItemIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllItemIdsAsync(cts.GetTokenOrDefault());

            //var items = result.Randomize().Select(x => _api.GetItemAync(x)).Race();
            //var results = new Dictionary<Type, Item>();

            //await foreach (var item in items)
            //{
            //    try
            //    {
            //        if (item is Key)
            //        {
            //            break;
            //        }
            //        results.TryAdd(item.GetType(), item);
            //    }
            //    catch (Exception e)
            //    {
            //        var i = 1;
            //    }
            //}

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetItemAync_TestData()
            => new List<object[]>
            {
                new TestItem[]
                {
                    new(100, "Rampager's Seer Coat of Divinity", typeof(Armor)),
                    new(56, "Strong Back Brace", typeof(Back)),
                    new(9480, "8 Slot Invisible Bag", typeof(Bag)),
                    new(12528, "Bowl of Fancy Tangy Sautee Mix", typeof(CraftingMaterial)),
                    new(89682, "Recipe: Diviner's Short Bow", typeof(Consumable)),
                    new(36520, "Bag of Coins", typeof(Container)),
                    new(87472, "Harvesting Sickle of Bounty", typeof(Gathering)),
                    new(22335, "Commander's Compendium", typeof(Gizmo)),
                    new(20211, "Mini Black Moa", typeof(MiniPet)),
                    new(19986, "Black Lion Salvage Kit", typeof(Tool)),
                    new(23190, "Carrion Amulet", typeof(Trinket)),
                    new(91072, "Vision of Action: Sandswept Isles", typeof(Trophy)),
                    new(91453, "Superior Sigil of Mad Scientists", typeof(UpgradeComponent)),
                    new(6, "((208738))", typeof(Weapon)),
                },
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetItemAync_TestData), DynamicDataSourceType.Method)]
        public async Task GetItemAync_ValidItemId_ReturnsThatItem(TestItem item, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetItemAync(item.Id, item.Lang, cts.GetTokenOrDefault());

            Assert.AreEqual(item.Name, result.Name);
            Assert.AreEqual(item.Type, result.GetType());
        }

        public static IEnumerable<object[]> GetItemAyncWithLang_TestData()
            => new List<object[]>
            {
                new object[]
                {
                    new TestItem(100, "Abrigo de vidente de divinidad de violento", typeof(Armor), "es")
                },
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetItemAyncWithLang_TestData), DynamicDataSourceType.Method)]
        public async Task GetItemAync_ValidItemIdAndNonNullLang_ReturnsThatItemInThatLang(TestItem item, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetItemAync(item.Id, item.Lang, cts.GetTokenOrDefault());

            Assert.AreEqual(item.Name, result.Name);
            Assert.AreEqual(item.Type, result.GetType());
        }

        public static IEnumerable<object[]> GetItemsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 100, 56, 9480 } },
                new [] {
                    (null, new List<string> { "Rampager's Seer Coat of Divinity", "Strong Back Brace", "8 Slot Invisible Bag" }.AsEnumerable()),
                    ("es", new List<string> { "Abrigo de vidente de divinidad de violento", "Corsé lumbar fuerte", "Saco invisible de 8 casillas" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetItemsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetItemsAsync_ValidIds_ReturnsThoseItems(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetItemsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }
    }
}
