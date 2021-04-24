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
using GW2Api.NET.V2.Items.Dto.Skins;
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
        public async Task GetAllFinisherIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllFinisherIdsAsync(cts.GetTokenOrDefault());

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
        public async Task GetAllFinishersAsync_AnyParams_ReturnsAllFinishers(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllFinishersAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetFinishersAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
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

            // The following is helpful for finding an item of a specific type efficiently

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
                new TestObject[]
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
        public async Task GetItemAync_ValidItemId_ReturnsThatItem(TestObject item, Func<CancellationTokenSource> ctsFactory)
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
                    new TestObject(100, "Abrigo de vidente de divinidad de violento", typeof(Armor), "es")
                },
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetItemAyncWithLang_TestData), DynamicDataSourceType.Method)]
        public async Task GetItemAync_ValidItemIdAndNonNullLang_ReturnsThatItemInThatLang(TestObject item, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetItemAync(item.Id, item.Lang, cts.GetTokenOrDefault());

            Assert.AreEqual(item.Name, result.Name);
            Assert.AreEqual(item.Type, result.GetType());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetItemsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetItemsAsync(ids: null, lang, cts.GetTokenOrDefault());
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

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllItemStatsIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllItemStatsIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetItemStatsAsync_TestData()
            => new List<object[]>
            {
                new object[] { 1230 },
                new [] { (null, "Seraph"), ("es", "Serafín") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetItemStatsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetItemStatsAsync_ValidId_ReturnsThatItemStats(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetItemStatsAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetItemStatsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetItemStatsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetItemStatsAsync_MultipleIds_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1230, 1231, 1232 } },
                new [] {
                    (null, new List<string> { "Seraph", "Marauder", "Crusader" }.AsEnumerable()),
                    ("es", new List<string> { "Serafín", "de salteador", "de cruzado" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetItemStatsAsync_MultipleIds_TestData), DynamicDataSourceType.Method)]
        public async Task GetItemStatsAsync_ValidIds_ReturnsThoseItemStats(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetItemStatsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllItemStatsAsync_AnyParams_ReturnsAllItemStats(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllItemStatsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMaterialIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMaterialIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetMaterialAsync_TestData()
            => new List<object[]>
            {
                new object[] { 5 },
                new [] { (null, "Cooking Materials"), ("es", "Materiales de cocina") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetMaterialAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetMaterialAsync_ValidId_ReturnsThatMaterial(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetMaterialAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMaterialsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetMaterialsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetMaterialsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 5, 6, 29 } },
                new [] {
                    (null, new List<string> { "Cooking Materials", "Basic Crafting Materials", "Intermediate Crafting Materials" }.AsEnumerable()),
                    ("es", new List<string> { "Materiales de cocina", "Materiales de artesanía básicos", "Materiales de artesanía intermedios" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetMaterialsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetMaterialsAsync_ValidIds_ReturnsThoseMaterials(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetMaterialsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMaterialsAsync_AnyParams_ReturnsAllMaterials(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMaterialsAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllRecipeIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllRecipeIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetRecipeAsync_ValidId_ReturnsThatRecipe(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = 1;

            var result = await _api.GetRecipeAsync(id, cts.GetTokenOrDefault());

            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetRecipesAsync_NullIds_ThrowsArgumentNullException(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetRecipesAsync(ids: null, cts.GetTokenOrDefault());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task SearchRecipesByInputAsync_ValidId_ReturnsThoseRecipes(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = 46731;
            var ids = new List<int>
            {
                7314,
                7841,
                7846,
                7847,
                7848,
                7849,
                7850,
                10296,
                10310,
                10718,
                11234,
                11236,
                12045,
                12510,
                13168,
                13254
            };

            var result = await _api.SearchRecipesByInputAsync(id, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task SearchRecipesByOutputAsync_ValidId_ReturnsThoseRecipes(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var id = 50065;
            var ids = new List<int>
            {
                8455,
                8459,
                8460
            };

            var result = await _api.SearchRecipesByOutputAsync(id, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetRecipesAsync_ValidId_ReturnsThoseRecipes(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var ids = new List<int> { 1, 2, 3 };

            var result = await _api.GetRecipesAsync(ids, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(ids, result.Select(x => x.Id).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllSkinIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllSkinIdsAsync(cts.GetTokenOrDefault());

            // The following is helpful for finding an item of a specific type efficiently

            //var skins = result.Randomize().Select(x => _api.GetSkinAsync(x)).Race();
            //var results = new Dictionary<Type, Skin>();

            //await foreach (var skin in skins)
            //{
            //    try
            //    {
            //        if (skin is NET.V2.Items.Dto.Skins.SkinTypes.Gathering.Gathering)
            //        {
            //            break;
            //        }
            //        results.TryAdd(skin.GetType(), skin);
            //    }
            //    catch (Exception e)
            //    {
            //        var i = 1;
            //    }
            //}

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetSkinAsync_TestData()
            => new List<object[]>
            {
                new TestObject[]
                {
                    new(362, "Wrangler Boots", typeof(NET.V2.Items.Dto.Skins.SkinTypes.Armor.Armor)),
                    new(7692, "Banners of the Sunspear Order", typeof(NET.V2.Items.Dto.Skins.SkinTypes.Back.Back)),
                    new(8083, "Super Adventure Logging Bear", typeof(NET.V2.Items.Dto.Skins.SkinTypes.Gathering.Gathering)),
                    new(4483, "Golden Wing Harpoon", typeof(NET.V2.Items.Dto.Skins.SkinTypes.Weapon.Weapon)),
                },
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetSkinAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetSkinAsync_ValidId_ReturnsThatSkin(TestObject skin, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetSkinAsync(skin.Id, skin.Lang, cts.GetTokenOrDefault());

            Assert.AreEqual(skin.Name, result.Name);
            Assert.AreEqual(skin.Type, result.GetType());
        }

        public static IEnumerable<object[]> GetSkinAyncWithLang_TestData()
            => new List<object[]>
            {
                new TestObject[]
                {
                    new(362, "Botas de mayoral", typeof(NET.V2.Items.Dto.Skins.SkinTypes.Armor.Armor), "es"),
                },
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetSkinAyncWithLang_TestData), DynamicDataSourceType.Method)]
        public async Task GetSkinAsync_ValidIdAndNonNullLang_ReturnsThatSkinInThatLang(TestObject skin, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetSkinAsync(skin.Id, skin.Lang, cts.GetTokenOrDefault());

            Assert.AreEqual(skin.Name, result.Name);
            Assert.AreEqual(skin.Type, result.GetType());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetSkinsAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetSkinsAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetSkinsAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 362, 7692, 8083 } },
                new [] {
                    (null, new List<string> { "Wrangler Boots", "Banners of the Sunspear Order", "Super Adventure Logging Bear" }.AsEnumerable()),
                    ("es", new List<string> { "Botas de mayoral", "Estandartes de la Orden de los Lanceros del Sol", "Oso leñador superaventurero" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetSkinsAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetSkinsAsync_ValidIds_ReturnsThoseSkins(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetSkinsAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMiniIdsAsync_AnyParams_ReturnsAllIds(Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMiniIdsAsync(cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        public static IEnumerable<object[]> GetMiniAsync_TestData()
            => new List<object[]>
            {
                new object[] { 1 },
                new [] { (null, "Mini Rytlock"), ("es", "Miniatura de Rytlock") }.ToLangStrObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetMiniAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetMiniAsync_ValidId_ReturnsThatMini(int id, (CultureInfo, string) langNameTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, name) = langNameTuple;

            var result = await _api.GetMiniAsync(id, lang, cts.GetTokenOrDefault());

            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMinisAsync_NullIds_ThrowsArgumentNullException(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            await _api.GetMinisAsync(ids: null, lang, cts.GetTokenOrDefault());
        }

        public static IEnumerable<object[]> GetMinisAsync_TestData()
            => new List<object[]>
            {
                new [] { new List<int> { 1, 2, 228 } },
                new [] {
                    (null, new List<string> { "Mini Rytlock", "Mini Servitor Golem", "Mini Llama" }.AsEnumerable()),
                    ("es", new List<string> { "Miniatura de Rytlock", "Minigólem ordenanza", "Minillama" }.AsEnumerable())
                }.ToLangStrsObjectArray(),
                TestData.DefaultCtsFactories
            }.Permute();

        [DataTestMethod]
        [DynamicData(nameof(GetMinisAsync_TestData), DynamicDataSourceType.Method)]
        public async Task GetMinisAsync_ValidIds_ReturnsThoseMinis(IEnumerable<int> ids, (CultureInfo, IEnumerable<string>) langNamesTuple, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();
            var (lang, names) = langNamesTuple;

            var result = await _api.GetMinisAsync(ids, lang, cts.GetTokenOrDefault());

            CollectionAssert.AreEquivalent(names.ToList(), result.Select(x => x.Name).ToList());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetAllMinisAsync_AnyParams_ReturnsAllMinis(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetAllMinisAsync(lang, cts.GetTokenOrDefault());

            Assert.IsTrue(result.Any());
        }

        [DataTestMethod]
        [DynamicData(nameof(TestData.DefaultLangTestData), typeof(TestData), DynamicDataSourceType.Method)]
        public async Task GetMinisAsync_NoIds_ReturnsAPage(CultureInfo lang, Func<CancellationTokenSource> ctsFactory)
        {
            using var cts = ctsFactory();

            var result = await _api.GetMinisAsync(lang: lang, token: cts.GetTokenOrDefault());

            Assert.IsTrue(result.Data.Any());
        }
    }
}
