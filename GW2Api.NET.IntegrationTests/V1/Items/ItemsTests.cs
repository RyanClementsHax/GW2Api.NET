using GW2Api.NET.V1;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Armor;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Back;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Bag;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Consumable.ConsumableTypes.UnlockTypes;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Container;
using GW2Api.NET.V1.Items.Dto.ItemTypes.CraftingMaterial;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Gathering;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Gizmo;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Minipet;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Tool;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Trinket;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Trophy;
using GW2Api.NET.V1.Items.Dto.ItemTypes.UpgradeComponent;
using GW2Api.NET.V1.Items.Dto.ItemTypes.Weapon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Items
{
    // some item detail types or sub stypes are missing test coverage
    // due to how hard it is to find item detail that I can assert against
    [TestClass, TestCategory("Large"), TestCategory("V1"), TestCategory("V1 Items")]
    public class ItemsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup()
            => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllItemIdsAsync_NoParams_ReturnsItemIds()
        {
            var itemIds = await _api.GetAllItemIdsAsync();

            Assert.IsTrue(itemIds.Any());
        }

        [TestMethod]
        public async Task GetAllItemIdsAsync_CancellationToken_ReturnsItemIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var itemIds = await _api.GetAllItemIdsAsync(token: cts.Token);

            //foreach (var item in itemIds)
            //{
            //    var itemDetail = await _api.GetItemDetail(item);
            //    if(itemDetail is GatheringDetail)
            //    {
            //        break;
            //    }
            //}

            Assert.IsTrue(itemIds.Any());
        }

        // missing trait type due to difficulty of procuring examples
        [TestMethod]
        [DataRow(100, "Rampager's Seer Coat of Divinity", typeof(ArmorDetail))]
        [DataRow(56, "Strong Back Brace", typeof(BackDetail))]
        [DataRow(9480, "8 Slot Invisible Bag", typeof(BagDetail))]
        [DataRow(36520, "Bag of Coins", typeof(ContainerDetail))]
        [DataRow(13000, "Bronze Trident Head", typeof(CraftingMaterialDetail))]
        [DataRow(87472, "Harvesting Sickle of Bounty", typeof(GatheringDetail))]
        [DataRow(22335, "Commander's Compendium", typeof(GizmoDetail))]
        [DataRow(20211, "Mini Black Moa", typeof(MinipetDetail))]
        [DataRow(49424, "+1 Agony Infusion", typeof(UpgradeComponentDetail))]
        [DataRow(19986, "Black Lion Salvage Kit", typeof(ToolDetail))]
        [DataRow(23190, "Carrion Amulet", typeof(TrinketDetail))]
        [DataRow(91072, "Vision of Action: Sandswept Isles", typeof(TrophyDetail))]
        [DataRow(6, "((208738))", typeof(WeaponDetail))]
        public async Task GetItemDetailAsync_ValidItemId_ReturnsThatItemDetail(int itemId, string itemName, Type type)
        {
            var itemDetail = await _api.GetItemDetailAsync(itemId);

            Assert.AreEqual(itemName, itemDetail.Name);
            Assert.AreEqual(type, itemDetail.GetType());
        }

        // missing some types due to difficulty of procuring examples
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
        public async Task GetItemDetailAsync_ValidConsumableItemId_ReturnsThatItemDetail(int itemId, string itemName, Type type)
        {
            var itemDetail = await _api.GetItemDetailAsync(itemId);

            Assert.AreEqual(itemName, itemDetail.Name);
            Assert.IsTrue(itemDetail is ConsumableDetail);
            Assert.AreEqual(type, ((ConsumableDetail)itemDetail).Consumable.GetType());
        }

        // missing some types due to difficulty of procuring examples
        [TestMethod]
        [DataRow(10000, "Recipe: Satchel of Rejuvenating Masquerade Armor (Rare)", typeof(CraftingRecipe))]
        [DataRow(20356, "Abyss Dye", typeof(Dye))]
        [DataRow(19988, "Limited-Use Cow Finisher", typeof(Content))]
        public async Task GetItemDetailAsync_ValidUnlockConsumableItemId_ReturnsThatItemDetail(int itemId, string itemName, Type type)
        {
            var itemDetail = await _api.GetItemDetailAsync(itemId);

            Assert.AreEqual(itemName, itemDetail.Name);
            Assert.IsTrue(itemDetail is ConsumableDetail);
            var consumableDetail = itemDetail as ConsumableDetail;
            Assert.IsTrue(consumableDetail.Consumable is Unlock);
            Assert.AreEqual(type, consumableDetail.Consumable.GetType());
        }

        [TestMethod]
        public async Task GetItemDetailAsync_ValidItemIdAndCancellationToken_ReturnsThatItemDetail()
        {
            using var cts = TestData.CreateDefaultTokenSource();
            var itemId = 6;
            var itemName = "((208738))";

            var itemDetail = await _api.GetItemDetailAsync(itemId, token: cts.Token);

            Assert.AreEqual(itemName, itemDetail.Name);
        }
    }
}
