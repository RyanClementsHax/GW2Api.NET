using GW2Api.NET.V1;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Armor;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Back;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Bag;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes.UnlockTypes;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Container;
using GW2Api.NET.V1.Items.Dto.ItemTypes.CraftingMaterial;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Weapon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Items
{
    [TestClass, TestCategory("Large"), TestCategory("Items")]
    public class ItemsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup() => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllItemIds_NoParams_ReturnsItemIds()
        {
            var itemIds = await _api.GetAllItemIds();

            Assert.IsTrue(itemIds.Any());
        }

        [TestMethod]
        public async Task GetAllItemIds_CancellationToken_ReturnsItemIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var itemIds = await _api.GetAllItemIds(token: cts.Token);

            Assert.IsTrue(itemIds.Any());
        }

        [TestMethod]
        [DataRow(100, "Rampager's Seer Coat of Divinity", typeof(ArmorDetail))]
        [DataRow(56, "Strong Back Brace", typeof(BackDetail))]
        [DataRow(9480, "8 Slot Invisible Bag", typeof(BagDetail))]
        [DataRow(36520, "Bag of Coins", typeof(ContainerDetail))]
        [DataRow(13000, "Bronze Trident Head", typeof(CraftingMaterialDetail))]
        [DataRow(6, "((208738))", typeof(WeaponDetail))]
        public async Task GetItemDetail_ValidItemId_ReturnsThatItemDetail(int itemId, string itemName, Type type)
        {
            var itemDetail = await _api.GetItemDetail(itemId);

            Assert.AreEqual(itemName, itemDetail.Name);
            Assert.AreEqual(itemDetail.GetType(), type);
        }

        [TestMethod]
        [DataRow(36284, "Self-Style Hair Kit", typeof(AppearanceChange))]
        [DataRow(50018, "Maintenance Oil Station", typeof(Generic))] // with effect
        [DataRow(24, "Sealed Package of Snowballs", typeof(Generic))] // without effect
        [DataRow(8553, "Bottle of Red Wine", typeof(Booze))]
        [DataRow(8471, "Transmutation Crystal", typeof(Generic))] // transmutation (turns out it is actually generic tho)
        [DataRow(8472, "Transmutation Splitter", typeof(Generic))] // untransmutation (turns out it is actually generic tho)
        [DataRow(8473, "Supply Package", typeof(Immediate))]
        [DataRow(12549, "Chili Pepper Popper", typeof(Food))] // with effect
        [DataRow(12557, "Tray of Strawberry Pies", typeof(Food))] // without effect
        [DataRow(8493, "Extended Potion of Ghost Slaying", typeof(Utility))] // with effect
        [DataRow(8640, "Grawl Snowman Potion", typeof(Utility))] // without effect
        [DataRow(20010, "Rejuvenation Booster", typeof(Halloween))]
        [DataRow(20017, "Trading Post Express", typeof(ContractNpc))]
        [DataRow(20349, "Upgrade Extractor", typeof(UpgradeRemoval))]
        public async Task GetItemDetail_ValidConsumableItemId_ReturnsThatItemDetail(int itemId, string itemName, Type type)
        {
            var itemDetail = await _api.GetItemDetail(itemId);

            Assert.AreEqual(itemName, itemDetail.Name);
            Assert.IsTrue(itemDetail is ConsumableDetail);
            Assert.AreEqual(((ConsumableDetail)itemDetail).Consumable.GetType(), type);
        }

        [TestMethod]
        [DataRow(10000, "Recipe: Satchel of Rejuvenating Masquerade Armor (Rare)", typeof(CraftingRecipe))]
        [DataRow(20356, "Abyss Dye", typeof(Dye))]
        [DataRow(19988, "Limited-Use Cow Finisher", typeof(Content))]
        public async Task GetItemDetail_ValidUnlockConsumableItemId_ReturnsThatItemDetail(int itemId, string itemName, Type type)
        {
            var itemDetail = await _api.GetItemDetail(itemId);

            Assert.AreEqual(itemName, itemDetail.Name);
            Assert.IsTrue(itemDetail is ConsumableDetail);
            var consumableDetail = itemDetail as ConsumableDetail;
            Assert.IsTrue(consumableDetail.Consumable is Unlock);
            Assert.AreEqual(consumableDetail.Consumable.GetType(), type);
        }

        [TestMethod]
        public async Task GetItemDetail_ValidItemIdAndCancellationToken_ReturnsThatItemDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var itemId = 6;
            var itemName = "((208738))";

            var itemDetail = await _api.GetItemDetail(itemId, token: cts.Token);

            Assert.AreEqual(itemName, itemDetail.Name);
        }
    }
}
