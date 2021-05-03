# V2 Client Method Documentation

- [V2 Client Method Documentation](#v2-client-method-documentation)
  - [Accounts](#accounts)
    - [account](#account)
    - [account/achievements](#accountachievements)
    - [account/bank](#accountbank)
    - [account/dailycrafting](#accountdailycrafting)
    - [account/dungeons](#accountdungeons)
    - [account/dyes](#accountdyes)
    - [account/finishers](#accountfinishers)
    - [account/gliders](#accountgliders)
    - [account/home/cats](#accounthomecats)
    - [account/home/nodes](#accounthomenodes)
    - [account/inventory](#accountinventory)
    - [account/luck](#accountluck)
    - [account/mailcarriers](#accountmailcarriers)
    - [account/mapchests](#accountmapchests)
    - [account/masteries](#accountmasteries)
    - [account/mastery/points](#accountmasterypoints)
    - [account/materials](#accountmaterials)
    - [account/minis](#accountminis)
    - [account/mounts/skins](#accountmountsskins)
    - [account/mounts/types](#accountmountstypes)
    - [account/novelties](#accountnovelties)
    - [account/outfits](#accountoutfits)
    - [account/pvp/heroes](#accountpvpheroes)
    - [account/raids](#accountraids)
    - [account/recipes](#accountrecipes)
    - [account/skins](#accountskins)
    - [account/titles](#accounttitles)
    - [account/wallet](#accountwallet)
    - [account/worldbosses](#accountworldbosses)
  - [Achievements](#achievements)
    - [achievements](#achievements-1)
    - [achievements/daily](#achievementsdaily)
    - [achievements/daily/tomorrow](#achievementsdailytomorrow)
    - [achievements/groups](#achievementsgroups)
    - [achievements/categories](#achievementscategories)
  - [Builds](#builds)
    - [build](#build)
  - [Characters](#characters)
    - [characters](#characters-1)
    - [characters/backstory](#charactersbackstory)
    - [characters/core](#characterscore)
    - [characters/crafting](#characterscrafting)
    - [characters/equipment](#charactersequipment)
    - [characters/heropoints](#charactersheropoints)
    - [characters/inventory](#charactersinventory)
    - [characters/recipes](#charactersrecipes)
    - [characters/sab](#characterssab)
    - [characters/skills](#charactersskills)
    - [characters/specialization](#charactersspecialization)
    - [characters/training](#characterstraining)
  - [Colors](#colors)
    - [colors](#colors-1)
  - [Commerce](#commerce)
    - [commerce/delivery](#commercedelivery)
    - [commerce/exchange/coins](#commerceexchangecoins)
    - [commerce/exchange/gems](#commerceexchangegems)
    - [commerce/listings](#commercelistings)
    - [commerce/prices](#commerceprices)
    - [commerce/transactions](#commercetransactions)
  - [Currencies](#currencies)
    - [currencies](#currencies-1)
  - [Dailies](#dailies)
    - [dailycrafting](#dailycrafting)
    - [mapchests](#mapchests)
    - [worldbosses](#worldbosses)
  - [Files](#files)
    - [files](#files-1)
    - [quaggans](#quaggans)

## Accounts

### [account](https://wiki.guildwars2.com/wiki/API:2/account)
```cs
Task<Account> GetAccountAsync(string accessToken = null, CancellationToken token = default);
```

### [account/achievements](https://wiki.guildwars2.com/wiki/API:2/account/achievements)
```cs
Task<IList<AccountAchievement>> GetAllAccountAchievementsAsync(string accessToken = null, CancellationToken token = default);
```
```cs
Task<AccountAchievement> GetAccountAchievementAsync(int id, string accessToken = null, CancellationToken token = default);
```
```cs
Task<IList<AccountAchievement>> GetAccountAchievementsAsync(IEnumerable<int> ids, string accessToken = null, CancellationToken token = default);
```

### [account/bank](https://wiki.guildwars2.com/wiki/API:2/account/bank)
```cs
Task<IList<BankSlot>> GetAccountBankAsync(string accessToken = null, CancellationToken token = default);
```

### [account/dailycrafting](https://wiki.guildwars2.com/wiki/API:2/account/dailycrafting)
```cs
Task<IList<string>> GetAccountDailyCraftingIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/dungeons](https://wiki.guildwars2.com/wiki/API:2/account/dungeons)
```cs
Task<IList<string>> GetAccountDungeonIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/dyes](https://wiki.guildwars2.com/wiki/API:2/account/dyes)
```cs
Task<IList<int>> GetAccountDyeIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/finishers](https://wiki.guildwars2.com/wiki/API:2/account/finishers)
```cs
Task<IList<FinisherSummary>> GetAccountFinisherSummariesAsync(string accessToken = null, CancellationToken token = default);
```

### [account/gliders](https://wiki.guildwars2.com/wiki/API:2/account/gliders)
```cs
Task<IList<int>> GetAccountGliderIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/home/cats](https://wiki.guildwars2.com/wiki/API:2/account/home/cats)
```cs
Task<IList<int>> GetAccountHomeCatIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/home/nodes](https://wiki.guildwars2.com/wiki/API:2/account/home/nodes)
```cs
Task<IList<string>> GetAccountHomeNodeIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/inventory](https://wiki.guildwars2.com/wiki/API:2/account/inventory)
```cs
Task<IList<SharedInventorySlot>> GetAccountSharedInventorySlotsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/luck](https://wiki.guildwars2.com/wiki/API:2/account/luck)
```cs
Task<IList<ConsumedLuck>> GetAccountLuckAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mailcarriers](https://wiki.guildwars2.com/wiki/API:2/account/mailcarriers)
```cs
Task<IList<int>> GetAccountMailCarrierIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mapchests](https://wiki.guildwars2.com/wiki/API:2/account/mapchests)
```cs
Task<IList<string>> GetAccountMapChestIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/masteries](https://wiki.guildwars2.com/wiki/API:2/account/masteries)
```cs
Task<IList<MasterySummary>> GetAccountMasterySummariesAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mastery/points](https://wiki.guildwars2.com/wiki/API:2/account/mastery/points)
```cs
Task<MasteryPointSummary> GetAccountMasteryPointSummaryAsync(string accessToken = null, CancellationToken token = default);
```

### [account/materials](https://wiki.guildwars2.com/wiki/API:2/account/materials)
```cs
Task<IList<MaterialSummary>> GetAccountMaterialSummariesAsync(string accessToken = null, CancellationToken token = default);
```

### [account/minis](https://wiki.guildwars2.com/wiki/API:2/account/minis)
```cs
Task<IList<int>> GetAccountMinisIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mounts/skins](https://wiki.guildwars2.com/wiki/API:2/account/mounts/skins)
```cs
Task<IList<int>> GetAccountMountSkinIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/mounts/types](https://wiki.guildwars2.com/wiki/API:2/account/mounts/types)
```cs
Task<IList<string>> GetAccountMountTypeIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/novelties](https://wiki.guildwars2.com/wiki/API:2/account/novelties)
```cs
Task<IList<int>> GetAccountNoveltyIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/outfits](https://wiki.guildwars2.com/wiki/API:2/account/outfits)
```cs
Task<IList<int>> GetAccountOutfitIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/pvp/heroes](https://wiki.guildwars2.com/wiki/API:2/account/pvp/heroes)
```cs
Task<IList<int>> GetAccountPvpHeroIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/raids](https://wiki.guildwars2.com/wiki/API:2/account/raids)
```cs
Task<IList<string>> GetAccountRaidIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/recipes](https://wiki.guildwars2.com/wiki/API:2/account/recipes)
```cs
Task<IList<int>> GetAccountRecipeIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/skins](https://wiki.guildwars2.com/wiki/API:2/account/skins)
```cs
Task<IList<int>> GetAccountSkinIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/titles](https://wiki.guildwars2.com/wiki/API:2/account/titles)
```cs
Task<IList<int>> GetAccountTitleIdsAsync(string accessToken = null, CancellationToken token = default);
```

### [account/wallet](https://wiki.guildwars2.com/wiki/API:2/account/wallet)
```cs
Task<IList<CurrencySummary>> GetAccountWalletAsync(string accessToken = null, CancellationToken token = default);
```

### [account/worldbosses](https://wiki.guildwars2.com/wiki/API:2/account/worldbosses)
```cs
Task<IList<string>> GetAccountWorldBossIdsAsync(string accessToken = null, CancellationToken token = default);
```

## Achievements

### [achievements](https://wiki.guildwars2.com/wiki/API:2/achievements)
```cs
Task<IList<int>> GetAllAchievementIdsAsync(CancellationToken token = default);
```
```cs
Task<Achievement> GetAchievementAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Achievement>> GetAchievementsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Achievement>>> GetAchievementsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [achievements/daily](https://wiki.guildwars2.com/wiki/API:2/achievements/daily)
```cs
Task<DailyAchievements> GetTodaysDailyAchievementsAsync(CancellationToken token = default);
```

### [achievements/daily/tomorrow](https://wiki.guildwars2.com/wiki/API:2/achievements/daily/tomorrow)
```cs
Task<DailyAchievements> GetTomorrowsDailyAchievementsAsync(CancellationToken token = default);
```

### [achievements/groups](https://wiki.guildwars2.com/wiki/API:2/achievements/categories)
```cs
Task<IList<Guid>> GetAllAchievementGroupIdsAsync(CancellationToken token = default);
```
```cs
Task<AchievementGroup> GetAchievementGroupAsync(Guid id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<AchievementGroup>> GetAchievementGroupsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<AchievementGroup>> GetAllAchievementGroupsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<AchievementGroup>>> GetAchievementGroupsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [achievements/categories](https://wiki.guildwars2.com/wiki/API:2/achievements/categories)
```cs
Task<IList<int>> GetAllAchievementCategoryIdsAsync(CancellationToken token = default);
```
```cs
Task<AchievementCategory> GetAchievementCategoryAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<AchievementCategory>> GetAchievementCategoriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<AchievementCategory>> GetAllAchievementCategoriesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<AchievementCategory>>> GetAchievementCategorysAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Builds

### [build](https://wiki.guildwars2.com/wiki/API:2/build)
```cs
Task<int> GetBuildAsync(CancellationToken token = default);
```

## Characters

### [characters](https://wiki.guildwars2.com/wiki/API:2/characters)
```cs
Task<IList<string>> GetAllCharacterIdsAsync(string accessToken = null, CancellationToken token = default);
```
```cs
Task<Character> GetCharacterAsync(string id, string accessToken = null, CancellationToken token = default);
```
```cs
Task<IList<Character>> GetCharactersAsync(IEnumerable<string> ids, string accessToken = null, CancellationToken token = default);
```
```cs
Task<IList<Character>> GetAllCharactersAsync(string accessToken = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Character>>> GetCharactersAsync(int page = 0, int pageSize = -1, string accessToken = null, CancellationToken token = default);
```

### [characters/backstory](https://wiki.guildwars2.com/wiki/API:2/characters/backstory)
```cs
Task<IList<string>> GetCharacterBackstoryAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/core](https://wiki.guildwars2.com/wiki/API:2/characters/core)
```cs
Task<CharacterCore> GetCharacterCoreAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/crafting](https://wiki.guildwars2.com/wiki/API:2/characters/crafting)
```cs
Task<IList<CraftingDiscipline>> GetCharacterCraftingAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/equipment](https://wiki.guildwars2.com/wiki/API:2/characters/equipment)
```cs
Task<IList<Equipment>> GetCharacterEquipmentAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/heropoints](https://wiki.guildwars2.com/wiki/API:2/characters/heropoints)
```cs
Task<IList<string>> GetCharacterHeroPointsAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/inventory](https://wiki.guildwars2.com/wiki/API:2/characters/inventory)
```cs
Task<IList<Bag>> GetCharacterInventoryAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/recipes](https://wiki.guildwars2.com/wiki/API:2/characters/recipes)
```cs
Task<IList<int>> GetCharacterRecipesAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/sab](https://wiki.guildwars2.com/wiki/API:2/characters/sab)
```cs
Task<Sab> GetCharacterSabAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/skills](https://wiki.guildwars2.com/wiki/API:2/characters/skills)
```cs
Task<Skills> GetCharacterSkillsAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/specialization](https://wiki.guildwars2.com/wiki/API:2/characters/specialization)
```cs
Task<Specializations> GetCharacterSpecializationsAsync(string id, string accessToken = null, CancellationToken token = default);
```

### [characters/training](https://wiki.guildwars2.com/wiki/API:2/characters/training)
```cs
Task<IList<CharacterTraining>> GetCharacterTrainingAsync(string id, string accessToken = null, CancellationToken token = default);
```

## Colors

### [colors](https://wiki.guildwars2.com/wiki/API:2/colors)
```cs
Task<IList<int>> GetAllColorIdsAsync(CancellationToken token = default);
```
```cs
Task<Color> GetColorAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Color>> GetColorsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Color>> GetAllColorsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Color>>> GetColorsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Commerce

### [commerce/delivery](https://wiki.guildwars2.com/wiki/API:2/commerce/delivery)
```cs
Task<Delivery> GetDeliveryAsync(string accessToken = null, CancellationToken token = default);
```

### [commerce/exchange/coins](https://wiki.guildwars2.com/wiki/API:2/commerce/exchange/coins)
```cs
Task<ExchangeInfo> GetCoinsToGemsExchangeInfoAsync(int quantity, CancellationToken token = default);
```

### [commerce/exchange/gems](https://wiki.guildwars2.com/wiki/API:2/commerce/exchange/gems)
```cs
Task<ExchangeInfo> GetGemsToCoinsExchangeInfoAsync(int quantity, CancellationToken token = default);
```

### [commerce/listings](https://wiki.guildwars2.com/wiki/API:2/commerce/listings)
```cs
Task<IList<int>> GetAllItemListingIdsAsync(CancellationToken token = default);
```
```cs
Task<ItemListing> GetItemListingAsync(int id, CancellationToken token = default);
```
```cs
Task<IList<ItemListing>> GetItemListingsAsync(IEnumerable<int> ids, CancellationToken token = default);
```
```cs
Task<Page<IList<ItemListing>>> GetItemListingsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [commerce/prices](https://wiki.guildwars2.com/wiki/API:2/commerce/prices)
```cs
Task<IList<int>> GetAllMarketPriceIdsAsync(CancellationToken token = default);
```
```cs
Task<MarketPrice> GetMarketPriceAsync(int id, CancellationToken token = default);
```
```cs
Task<IList<MarketPrice>> GetMarketPricesAsync(IEnumerable<int> ids, CancellationToken token = default);
```
```cs
Task<Page<IList<MarketPrice>>> GetMarketPricesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [commerce/transactions](https://wiki.guildwars2.com/wiki/API:2/commerce/transactions)
```cs
Task<Page<IList<Transaction>>> GetCurrentBuyTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Transaction>>> GetCurrentSellTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Transaction>>> GetHistoricalBuyTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Transaction>>> GetHistoricalSellTransactionsAsync(int page = -1, int pageSize = -1, string accessToken = null, CancellationToken token = default);
```

## Currencies

### [currencies](https://wiki.guildwars2.com/wiki/API:2/currencies)
```cs
Task<IList<int>> GetAllCurrencyIdsAsync(CancellationToken token = default);
```
```cs
Task<Currency> GetCurrencyAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Currency>> GetCurrenciesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Currency>> GetAllCurrenciesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Currency>>> GetCurrenciesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Dailies

### [dailycrafting](https://wiki.guildwars2.com/wiki/API:2/dailycrafting)
```cs
Task<IList<string>> GetAllTimeGatedRecipeIdsAsync(CancellationToken token = default);
```
```cs
Task<TimeGatedRecipe> GetTimeGatedRecipeAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<TimeGatedRecipe>> GetTimeGatedRecipesAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<TimeGatedRecipe>> GetAllTimeGatedRecipesAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<TimeGatedRecipe>>> GetTimeGatedRecipesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [mapchests](https://wiki.guildwars2.com/wiki/API:2/mapchests)
```cs
Task<IList<string>> GetAllMapChestIdsAsync(CancellationToken token = default);
```
```cs
Task<MapChest> GetMapChestAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<MapChest>> GetMapChestsAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<MapChest>> GetAllMapChestsAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<MapChest>>> GetMapChestsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [worldbosses](https://wiki.guildwars2.com/wiki/API:2/worldbosses)
```cs
Task<IList<string>> GetAllWorldBossIdsAsync(CancellationToken token = default);
```
```cs
Task<WorldBoss> GetWorldBossAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<WorldBoss>> GetWorldBossesAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<WorldBoss>> GetAllWorldBossesAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<WorldBoss>>> GetWorldBossesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

## Files

### [files](https://wiki.guildwars2.com/wiki/API:2/files)
```cs
Task<IList<string>> GetAllFileIdsAsync(CancellationToken token = default);
```
```cs
Task<File> GetFileAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<File>> GetFilesAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<File>> GetAllFilesAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<File>>> GetFilesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [quaggans](https://wiki.guildwars2.com/wiki/API:2/quaggans)
```cs
Task<IList<string>> GetAllQuagganIdsAsync(CancellationToken token = default);
```
```cs
Task<Quaggan> GetQuagganAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<Quaggan>> GetQuaggansAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<Quaggan>> GetAllQuaggansAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<Quaggan>>> GetQuaggansAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```
