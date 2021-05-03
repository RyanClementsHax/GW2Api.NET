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
  - [Game Mechanics](#game-mechanics)
    - [masteries](#masteries)
    - [mounts/skins](#mountsskins)
    - [mounts/types](#mountstypes)
    - [outfits](#outfits)
    - [pets](#pets)
    - [professions](#professions)
    - [races](#races)
    - [specializations](#specializations)
    - [skills](#skills)
    - [traits](#traits)
    - [legends](#legends)
    - [dungeons](#dungeons)
    - [raids](#raids)
    - [titles](#titles)
  - [Guilds](#guilds)
    - [guild/:id](#guildid)
    - [emblem/backgrounds](#emblembackgrounds)
    - [emblem/foregrounds](#emblemforegrounds)
    - [guild/permissions](#guildpermissions)
    - [guild/search](#guildsearch)
    - [guild/upgrades](#guildupgrades)
    - [guild/:id/log](#guildidlog)
    - [guild/:id/members](#guildidmembers)
    - [guild/:id/ranks](#guildidranks)
    - [guild/:id/stash](#guildidstash)
    - [guild/:id/storage](#guildidstorage)
    - [guild/:id/treasury](#guildidtreasury)
    - [guild/:id/teams](#guildidteams)
    - [guild/:id/upgrades](#guildidupgrades)
  - [Home](#home)
    - [home/cats](#homecats)
    - [home/nodes](#homenodes)
  - [Items](#items)
    - [finishers](#finishers)
    - [items](#items-1)
    - [itemstats](#itemstats)
    - [materials](#materials)
    - [recipes](#recipes)
    - [recipes/search](#recipessearch)
    - [skins](#skins)
    - [minis](#minis)
  - [Maps](#maps)
    - [continents](#continents)
    - [continents/:continentId/floors](#continentscontinentidfloors)
    - [continents/:continentId/floors/:floorId/regions](#continentscontinentidfloorsflooridregions)
    - [continents/:continentId/floors/:floorId/regions/:regionId/maps](#continentscontinentidfloorsflooridregionsregionidmaps)
    - [continents/:continentId/floors/:floorId/regions/:regionId/maps/:mapId/sectors](#continentscontinentidfloorsflooridregionsregionidmapsmapidsectors)
    - [continents/:continentId/floors/:floorId/regions/:regionId/maps/:mapId/pois](#continentscontinentidfloorsflooridregionsregionidmapsmapidpois)
    - [continents/:continentId/floors/:floorId/regions/:regionId/maps/:mapId/tasks](#continentscontinentidfloorsflooridregionsregionidmapsmapidtasks)
    - [maps](#maps-1)
  - [Novelties](#novelties)
    - [novelties](#novelties-1)
  - [Pvp](#pvp)
    - [pvp/stats](#pvpstats)
    - [pvp/games](#pvpgames)
    - [pvp/standings](#pvpstandings)
    - [pvp/amulets](#pvpamulets)
    - [pvp/ranks](#pvpranks)
    - [pvp/seasons](#pvpseasons)
    - [pvp/seasons/:id/leaderboards](#pvpseasonsidleaderboards)
  - [Stories](#stories)
    - [backstory/answers](#backstoryanswers)
    - [backstory/questions](#backstoryquestions)
    - [stories](#stories-1)
    - [stories/seasons](#storiesseasons)
    - [quests](#quests)
  - [Tokens](#tokens)
    - [createsubtoken](#createsubtoken)
    - [tokeninfo](#tokeninfo)
  - [Worlds](#worlds)
    - [worlds](#worlds-1)
  - [Wvw](#wvw)
    - [wvw/abilities](#wvwabilities)
    - [wvw/matches](#wvwmatches)
    - [wvw/matches/overview](#wvwmatchesoverview)
    - [wvw/matches/scores](#wvwmatchesscores)
    - [wvw/matches/stats](#wvwmatchesstats)
    - [wvw/objectives](#wvwobjectives)
    - [wvw/ranks](#wvwranks)
    - [wvw/upgrades](#wvwupgrades)

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

## Game Mechanics

### [masteries](https://wiki.guildwars2.com/wiki/API:2/masteries)
```cs
Task<IList<int>> GetAllMasteryIdsAsync(CancellationToken token = default);
```
```cs
Task<Mastery> GetMasteryAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Mastery>> GetMasteriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Mastery>> GetAllMasteriesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Mastery>>> GetMasteriesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [mounts/skins](https://wiki.guildwars2.com/wiki/API:2/mounts/skins)
```cs
Task<IList<int>> GetAllMountSkinIdsAsync(CancellationToken token = default);
```
```cs
Task<MountSkin> GetMountSkinAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<MountSkin>> GetMountSkinsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<MountSkin>> GetAllMountSkinsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<MountSkin>>> GetMountSkinsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [mounts/types](https://wiki.guildwars2.com/wiki/API:2/mounts/types)
```cs
Task<IList<string>> GetAllMountTypeIdsAsync(CancellationToken token = default);
```
```cs
Task<MountType> GetMountTypeAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<MountType>> GetMountTypesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<MountType>> GetAllMountTypesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<MountType>>> GetMountTypesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [outfits](https://wiki.guildwars2.com/wiki/API:2/outfits)
```cs
Task<IList<int>> GetAllOutfitIdsAsync(CancellationToken token = default);
```
```cs
Task<Outfit> GetOutfitAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Outfit>> GetOutfitsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Outfit>> GetAllOutfitsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Outfit>>> GetOutfitsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [pets](https://wiki.guildwars2.com/wiki/API:2/pets)
```cs
Task<IList<int>> GetAllPetIdsAsync(CancellationToken token = default);
```
```cs
Task<Pet> GetPetAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Pet>> GetPetsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Pet>> GetAllPetsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Pet>>> GetPetsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [professions](https://wiki.guildwars2.com/wiki/API:2/professions)
```cs
Task<IList<string>> GetAllProfessionIdsAsync(CancellationToken token = default);
```
```cs
Task<ProfessionDetails> GetProfessionAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<ProfessionDetails>> GetProfessionsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<ProfessionDetails>> GetAllProfessionsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<ProfessionDetails>>> GetProfessionsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [races](https://wiki.guildwars2.com/wiki/API:2/races)
```cs
Task<IList<string>> GetAllRaceIdsAsync(CancellationToken token = default);
```
```cs
Task<RaceDetails> GetRaceAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<RaceDetails>> GetRacesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<RaceDetails>> GetAllRacesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<RaceDetails>>> GetRacesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [specializations](https://wiki.guildwars2.com/wiki/API:2/specializations)
```cs
Task<IList<int>> GetAllSpecializationIdsAsync(CancellationToken token = default);
```
```cs
Task<Specialization> GetSpecializationAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Specialization>> GetSpecializationsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Specialization>> GetAllSpecializationsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Specialization>>> GetSpecializationsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [skills](https://wiki.guildwars2.com/wiki/API:2/skills)
```cs
Task<IList<int>> GetAllSkillIdsAsync(CancellationToken token = default);
```
```cs
Task<Skill> GetSkillAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Skill>> GetSkillsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Skill>> GetAllSkillsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Skill>>> GetSkillsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [traits](https://wiki.guildwars2.com/wiki/API:2/traits)
```cs
Task<IList<int>> GetAllTraitIdsAsync(CancellationToken token = default);
```
```cs
Task<Trait> GetTraitAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Trait>> GetTraitsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Trait>> GetAllTraitsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Trait>>> GetTraitsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [legends](https://wiki.guildwars2.com/wiki/API:2/legends)
```cs
Task<IList<string>> GetAllLegendIdsAsync(CancellationToken token = default);
```
```cs
Task<Legend> GetLegendAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Legend>> GetLegendsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Legend>> GetAllLegendsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Legend>>> GetLegendsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [dungeons](https://wiki.guildwars2.com/wiki/API:2/dungeons)
```cs
Task<IList<string>> GetAllDungeonIdsAsync(CancellationToken token = default);
```
```cs
Task<Dungeon> GetDungeonAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Dungeon>> GetDungeonsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Dungeon>> GetAllDungeonsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Dungeon>>> GetDungeonsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [raids](https://wiki.guildwars2.com/wiki/API:2/raids)
```cs
Task<IList<string>> GetAllRaidIdsAsync(CancellationToken token = default);
```
```cs
Task<Raid> GetRaidAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Raid>> GetRaidsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Raid>> GetAllRaidsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Raid>>> GetRaidsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [titles](https://wiki.guildwars2.com/wiki/API:2/titles)
```cs
Task<IList<int>> GetAllTitleIdsAsync(CancellationToken token = default);
```
```cs
Task<Title> GetTitleAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Title>> GetTitlesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Title>> GetAllTitlesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Title>>> GetTitlesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Guilds

### [guild/:id](https://wiki.guildwars2.com/wiki/API:2/guild/:id)
```cs
Task<IList<int>> GetAllTitleIdsAsync(CancellationToken token = default);
```

### [emblem/backgrounds](https://wiki.guildwars2.com/wiki/API:2/emblem/backgrounds)
```cs
Task<IList<int>> GetAllEmblemBackgroundIdsAsync(CancellationToken token = default);
```
```cs
Task<EmblemLayer> GetEmblemBackgroundAsync(int id, CancellationToken token = default);
```
```cs
Task<IList<EmblemLayer>> GetEmblemBackgroundsAsync(IEnumerable<int> ids, CancellationToken token = default);
```
```cs
Task<IList<EmblemLayer>> GetAllEmblemBackgroundsAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<EmblemLayer>>> GetEmblemBackgroundsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [emblem/foregrounds](https://wiki.guildwars2.com/wiki/API:2/emblem/foregrounds)
```cs
Task<IList<int>> GetAllEmblemForegroundIdsAsync(CancellationToken token = default);
```
```cs
Task<EmblemLayer> GetEmblemForegroundAsync(int id, CancellationToken token = default);
```
```cs
Task<IList<EmblemLayer>> GetEmblemForegroundsAsync(IEnumerable<int> ids, CancellationToken token = default);
```
```cs
Task<IList<EmblemLayer>> GetAllEmblemForegroundsAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<EmblemLayer>>> GetEmblemForegroundsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [guild/permissions](https://wiki.guildwars2.com/wiki/API:2/guild/permissions)
```cs
Task<IList<string>> GetAllGuildPermissionIdsAsync(CancellationToken token = default);
```
```cs
Task<GuildPermission> GetGuildPermissionAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<GuildPermission>> GetGuildPermissionsAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<GuildPermission>> GetAllGuildPermissionsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<GuildPermission>>> GetGuildPermissionsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [guild/search](https://wiki.guildwars2.com/wiki/API:2/guild/search)
```cs
Task<IList<Guid>> SearchGuildsByNameAsync(string name, CancellationToken token);
```

### [guild/upgrades](https://wiki.guildwars2.com/wiki/API:2/guild/upgrades)
```cs
Task<IList<int>> GetAllGuildUpgradeIdsAsync(CancellationToken token = default);
```
```cs
Task<GuildUpgrade> GetGuildUpgradeAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<GuildUpgrade>> GetGuildUpgradesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<GuildUpgrade>> GetAllGuildUpgradesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<GuildUpgrade>>> GetGuildUpgradesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [guild/:id/log](https://wiki.guildwars2.com/wiki/API:2/guild/:id/log)
```cs
Task<IList<GuildLog>> GetGuildLogsAsync(Guid guildId, int since = -1, string accessToken = null, CancellationToken token = default);
```

### [guild/:id/members](https://wiki.guildwars2.com/wiki/API:2/guild/:id/members)
```cs
Task<IList<GuildMember>> GetGuildMembersAsync(Guid guildId, string accessToken = null, CancellationToken token = default);
```

### [guild/:id/ranks](https://wiki.guildwars2.com/wiki/API:2/guild/:id/ranks)
```cs
Task<IList<GuildRank>> GetGuildRanksAsync(Guid guildId, string accessToken = null, CancellationToken token = default);
```

### [guild/:id/stash](https://wiki.guildwars2.com/wiki/API:2/guild/:id/stash)
```cs
Task<IList<GuildVaultSection>> GetGuildStashAsync(Guid guildId, string accessToken = null, CancellationToken token = default);
```

### [guild/:id/storage](https://wiki.guildwars2.com/wiki/API:2/guild/:id/storage)
```cs
Task<IList<GuildStorageSlot>> GetGuildStorageAsync(Guid guildId, string accessToken = null, CancellationToken token = default);
```

### [guild/:id/treasury](https://wiki.guildwars2.com/wiki/API:2/guild/:id/treasury)
```cs
Task<IList<GuildTreasurySlot>> GetGuildTreasuryAsync(Guid guildId, string accessToken = null, CancellationToken token = default);
```

### [guild/:id/teams](https://wiki.guildwars2.com/wiki/API:2/guild/:id/teams)
```cs
Task<IList<GuildTeam>> GetGuildTeamsAsync(Guid guildId, string accessToken = null, CancellationToken token = default);
```

### [guild/:id/upgrades](https://wiki.guildwars2.com/wiki/API:2/guild/:id/upgrades)
```cs
Task<IList<int>> GetGuildUpgradesAsync(Guid guildId, string accessToken = null, CancellationToken token = default);
```

## Home

### [home/cats](https://wiki.guildwars2.com/wiki/API:2/home/cats)
```cs
Task<IList<int>> GetAllHomeCatIdsAsync(CancellationToken token = default);
```
```cs
Task<HomeCat> GetHomeCatAsync(int id, CancellationToken token = default);
```
```cs
Task<IList<HomeCat>> GetHomeCatsAsync(IEnumerable<int> ids, CancellationToken token = default);
```
```cs
Task<IList<HomeCat>> GetAllHomeCatsAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<HomeCat>>> GetHomeCatsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [home/nodes](https://wiki.guildwars2.com/wiki/API:2/home/nodes)
```cs
Task<IList<string>> GetAllHomeNodeIdsAsync(CancellationToken token = default);
```
```cs
Task<HomeNode> GetHomeNodeAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<HomeNode>> GetHomeNodesAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<HomeNode>> GetAllHomeNodesAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<HomeNode>>> GetHomeNodesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

## Items

### [finishers](https://wiki.guildwars2.com/wiki/API:2/finishers)
```cs
Task<IList<int>> GetAllFinisherIdsAsync(CancellationToken token = default);
```
```cs
Task<Finisher> GetFinisherAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Finisher>> GetFinishersAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Finisher>> GetAllFinishersAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Finisher>>> GetFinishersAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [items](https://wiki.guildwars2.com/wiki/API:2/items)
```cs
Task<IList<int>> GetAllItemIdsAsync(CancellationToken token = default);
```
```cs
Task<Item> GetItemAync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Item>> GetItemsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Item>>> GetItemsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [itemstats](https://wiki.guildwars2.com/wiki/API:2/itemstats)
```cs
Task<IList<int>> GetAllItemStatsIdsAsync(CancellationToken token = default);
```
```cs
Task<ItemStats> GetItemStatsAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IEnumerable<ItemStats>> GetItemStatsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IEnumerable<ItemStats>> GetAllItemStatsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<ItemStats>>> GetItemStatsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [materials](https://wiki.guildwars2.com/wiki/API:2/materials)
```cs
Task<IList<int>> GetAllMaterialIdsAsync(CancellationToken token = default);
```
```cs
Task<Material> GetMaterialAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Material>> GetMaterialsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Material>> GetAllMaterialsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Material>>> GetMaterialsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [recipes](https://wiki.guildwars2.com/wiki/API:2/recipes)
```cs
Task<IList<int>> GetAllRecipeIdsAsync(CancellationToken token = default);
```
```cs
Task<Recipe> GetRecipeAsync(int id, CancellationToken token = default);
```
```cs
Task<IList<Recipe>> GetRecipesAsync(IEnumerable<int> ids, CancellationToken token = default);
```
```cs
Task<Page<IList<Recipe>>> GetRecipesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [recipes/search](https://wiki.guildwars2.com/wiki/API:2/recipes/search)
```cs
Task<IList<int>> SearchRecipesByInputAsync(int inputId, CancellationToken token = default);
```
```cs
Task<IList<int>> SearchRecipesByOutputAsync(int outputId, CancellationToken token = default);
```

### [skins](https://wiki.guildwars2.com/wiki/API:2/skins)
```cs
Task<IList<int>> GetAllSkinIdsAsync(CancellationToken token = default);
```
```cs
Task<Skin> GetSkinAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Skin>> GetSkinsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Skin>>> GetSkinsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [minis](https://wiki.guildwars2.com/wiki/API:2/minis)
```cs
Task<IList<int>> GetAllMiniIdsAsync(CancellationToken token = default);
```
```cs
Task<Mini> GetMiniAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Mini>> GetMinisAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Mini>> GetAllMinisAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Mini>>> GetMinisAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Maps

### [continents](https://wiki.guildwars2.com/wiki/API:2/continents)
```cs
Task<IList<int>> GetAllContinentIdsAsync(CancellationToken token = default);
```
```cs
Task<Continent> GetContinentAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Continent>> GetContinentsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Continent>> GetAllContinentsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Continent>>> GetContinentsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [continents/:continentId/floors](https://wiki.guildwars2.com/wiki/API:2/continents)
```cs
Task<IList<int>> GetAllFloorIdsAsync(int continentId, CancellationToken token = default);
```
```cs
Task<Floor> GetFloorAsync(int continentId, int floorId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Floor>> GetFloorsAsync(int continentId, IEnumerable<int> floorIds, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Floor>> GetAllFloorsAsync(int continentId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Floor>>> GetFloorsAsync(int continentId, int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [continents/:continentId/floors/:floorId/regions](https://wiki.guildwars2.com/wiki/API:2/continents)
```cs
Task<IList<int>> GetAllFloorRegionIdsAsync(int continentId, int floorId, CancellationToken token = default);
```
```cs
Task<FloorRegion> GetFloorRegionAsync(int continentId, int floorId, int regionId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<FloorRegion>> GetFloorRegionsAsync(int continentId, int floorId, IEnumerable<int> regionIds, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<FloorRegion>> GetAllFloorRegionsAsync(int continentId, int floorId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<FloorRegion>>> GetFloorRegionsAsync(int continentId, int floorId, int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [continents/:continentId/floors/:floorId/regions/:regionId/maps](https://wiki.guildwars2.com/wiki/API:2/continents)
```cs
Task<IList<int>> GetAllRegionMapIdsAsync(int continentId, int floorId, int regionId, CancellationToken token = default);
```
```cs
Task<RegionMap> GetRegionMapAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<RegionMap>> GetRegionMapsAsync(int continentId, int floorId, int regionId, IEnumerable<int> mapIds, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<RegionMap>> GetAllRegionMapsAsync(int continentId, int floorId, int regionId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<RegionMap>>> GetRegionMapsAsync(int continentId, int floorId, int regionId, int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [continents/:continentId/floors/:floorId/regions/:regionId/maps/:mapId/sectors](https://wiki.guildwars2.com/wiki/API:2/continents)
```cs
Task<IList<int>> GetAllSectorIdsAsync(int continentId, int floorId, int regionId, int mapId, CancellationToken token = default);
```
```cs
Task<Sector> GetSectorAsync(int continentId, int floorId, int regionId, int mapId, int sectorId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Sector>> GetSectorsAsync(int continentId, int floorId, int regionId, int mapId, IEnumerable<int> sectorIds, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Sector>> GetAllSectorsAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Sector>>> GetSectorsAsync(int continentId, int floorId, int regionId, int mapId, int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [continents/:continentId/floors/:floorId/regions/:regionId/maps/:mapId/pois](https://wiki.guildwars2.com/wiki/API:2/continents)
```cs
Task<IList<int>> GetAllPointOfInterestIdsAsync(int continentId, int floorId, int regionId, int mapId, CancellationToken token = default);
```
```cs
Task<PointOfInterest> GetPointOfInterestAsync(int continentId, int floorId, int regionId, int mapId, int pointOfInterestId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<PointOfInterest>> GetPointsOfInterestAsync(int continentId, int floorId, int regionId, int mapId, IEnumerable<int> pointOfInterestIds, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<PointOfInterest>> GetAllPointsOfInterestAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<PointOfInterest>>> GetPointsOfInterestAsync(int continentId, int floorId, int regionId, int mapId, int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [continents/:continentId/floors/:floorId/regions/:regionId/maps/:mapId/tasks](https://wiki.guildwars2.com/wiki/API:2/continents)
```cs
Task<IList<int>> GetAllMapTaskIdsAsync(int continentId, int floorId, int regionId, int mapId, CancellationToken token = default);
```
```cs
Task<MapTask> GetMapTaskAsync(int continentId, int floorId, int regionId, int mapId, int mapTaskId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<MapTask>> GetMapTasksAsync(int continentId, int floorId, int regionId, int mapId, IEnumerable<int> mapTaskIds, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<MapTask>> GetAllMapTasksAsync(int continentId, int floorId, int regionId, int mapId, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<MapTask>>> GetMapTasksAsync(int continentId, int floorId, int regionId, int mapId, int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [maps](https://wiki.guildwars2.com/wiki/API:2/maps)
```cs
Task<IList<int>> GetAllMapIdsAsync(CancellationToken token = default);
```
```cs
Task<Map> GetMapAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Map>> GetMapsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Map>> GetAllMapsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Map>>> GetMapsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Novelties

### [novelties](https://wiki.guildwars2.com/wiki/API:2/novelties)
```cs
Task<IList<int>> GetAllNoveltyIdsAsync(CancellationToken token = default);
```
```cs
Task<Novelty> GetNoveltyAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Novelty>> GetNoveltiesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Novelty>> GetAllNoveltiesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Novelty>>> GetNoveltiesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Pvp

### [pvp/stats](https://wiki.guildwars2.com/wiki/API:2/pvp/stats)
```cs
Task<PvpStats> GetPvpStatsAsync(string accessToken = null, CancellationToken token = default);
```

### [pvp/games](https://wiki.guildwars2.com/wiki/API:2/pvp/games)
```cs
Task<IList<Guid>> GetAllPvpGameIdsAsync(string accessToken = null, CancellationToken token = default);
```
```cs
Task<PvpGame> GetPvpGameAsync(Guid id, string accessToken = null, CancellationToken token = default);
```
```cs
Task<IList<PvpGame>> GetPvpGamesAsync(IEnumerable<Guid> ids, string accessToken = null, CancellationToken token = default);
```
```cs
Task<IList<PvpGame>> Get10MostRecentPvpGamesAsync(string accessToken = null, CancellationToken token = default);
```
```cs
Task<Page<IList<PvpGame>>> GetPvpGamesAsync(int page = 0, int pageSize = -1, string accessToken = null, CancellationToken token = default);
```

### [pvp/standings](https://wiki.guildwars2.com/wiki/API:2/pvp/standings)
Currently no methods implemented because I don't have access to an account with standings data. If you would like to donate an api key for an account that has this data for testing and deserialization verification, that would be greatly appreciated.

### [pvp/amulets](https://wiki.guildwars2.com/wiki/API:2/pvp/amulets)
```cs
Task<IList<int>> GetAllPvpAmuletIdsAsync(CancellationToken token = default);
```
```cs
Task<PvpAmulet> GetPvpAmuletAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<PvpAmulet>> GetPvpAmuletsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<PvpAmulet>> GetAllPvpAmuletsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<PvpAmulet>>> GetPvpAmuletsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [pvp/ranks](https://wiki.guildwars2.com/wiki/API:2/pvp/ranks)
```cs
Task<IList<int>> GetAllPvpRankIdsAsync(CancellationToken token = default);
```
```cs
Task<PvpRank> GetPvpRankAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<PvpRank>> GetPvpRanksAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<PvpRank>> GetAllPvpRanksAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<PvpRank>>> GetPvpRanksAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [pvp/seasons](https://wiki.guildwars2.com/wiki/API:2/pvp/seasons)
```cs
Task<IList<Guid>> GetAllPvpSeasonIdsAsync(CancellationToken token = default);
```
```cs
Task<PvpSeason> GetPvpSeasonAsync(Guid id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<PvpSeason>> GetPvpSeasonsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<PvpSeason>> GetAllPvpSeasonsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<PvpSeason>>> GetPvpSeasonsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [pvp/seasons/:id/leaderboards](https://wiki.guildwars2.com/wiki/API:2/pvp/seasons/:id/leaderboards)
```cs
Task<IList<LeaderboardResult>> GetAllPvpLeaderboardResultsAsync(Guid seasonId, LeaderboardType leaderboardType, LeagueType leagueType, CancellationToken token = default);
```
```cs
Task<Page<IList<LeaderboardResult>>> GetPvpLeaderboardResultsAsync(Guid seasonId, LeaderboardType leaderboardType, LeagueType leagueType, int page = 0, int pageSize = -1, CancellationToken token = default);
```

## Stories

### [backstory/answers](https://wiki.guildwars2.com/wiki/API:2/backstory/answers)
```cs
Task<IList<string>> GetAllBackstoryAnswerIdsAsync(CancellationToken token = default);
```
```cs
Task<BackstoryAnswer> GetBackstoryAnswerAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<BackstoryAnswer>> GetBackstoryAnswersAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<BackstoryAnswer>> GetAllBackstoryAnswersAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<BackstoryAnswer>>> GetBackstoryAnswersAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [backstory/questions](https://wiki.guildwars2.com/wiki/API:2/backstory/questions)
```cs
Task<IList<int>> GetAllBackstoryQuestionIdsAsync(CancellationToken token = default);
```
```cs
Task<BackstoryQuestion> GetBackstoryQuestionAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<BackstoryQuestion>> GetBackstoryQuestionsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<BackstoryQuestion>> GetAllBackstoryQuestionsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<BackstoryQuestion>>> GetBackstoryQuestionsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [stories](https://wiki.guildwars2.com/wiki/API:2/stories)
```cs
Task<IList<int>> GetAllStoryIdsAsync(CancellationToken token = default);
```
```cs
Task<Story> GetStoryAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Story>> GetStoriesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Story>> GetAllStoriesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Story>>> GetStoriesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [stories/seasons](https://wiki.guildwars2.com/wiki/API:2/stories/seasons)
```cs
Task<IList<Guid>> GetAllStorySeasonIdsAsync(CancellationToken token = default);
```
```cs
Task<StorySeason> GetStorySeasonAsync(Guid id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<StorySeason>> GetStorySeasonsAsync(IEnumerable<Guid> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<StorySeason>> GetAllStorySeasonsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<StorySeason>>> GetStorySeasonsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [quests](https://wiki.guildwars2.com/wiki/API:2/quests)
```cs
Task<IList<int>> GetAllQuestIdsAsync(CancellationToken token = default);
```
```cs
Task<Quest> GetQuestAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Quest>> GetQuestsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<Quest>> GetAllQuestsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<Quest>>> GetQuestsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Tokens

### [createsubtoken](https://wiki.guildwars2.com/wiki/API:2/createsubtoken)
```cs
Task<string> CreateSubTokenAsync(DateTimeOffset expire, Permissions permissions, IEnumerable<string> urls = null, string accessToken = null, CancellationToken token = default);
```

### [tokeninfo](https://wiki.guildwars2.com/wiki/API:2/tokeninfo)
```cs
Task<TokenInfo> GetTokenInfoAsync(string accessToken = null, CancellationToken token = default);
```

## Worlds

### [worlds](https://wiki.guildwars2.com/wiki/API:2/worlds)
```cs
Task<IList<int>> GetAllWorldIdsAsync(CancellationToken token = default);
```
```cs
Task<World> GetWorldAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<World>> GetWorldsAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<World>> GetAllWorldsAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<World>>> GetWorldsAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

## Wvw

### [wvw/abilities](https://wiki.guildwars2.com/wiki/API:2/wvw/abilities)
```cs
Task<IList<int>> GetAllWvwAbilityIdsAsync(CancellationToken token = default);
```
```cs
Task<WvwAbility> GetWvwAbilityAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<WvwAbility>> GetWvwAbilitiesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<WvwAbility>> GetAllWvwAbilitiesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<WvwAbility>>> GetWvwAbilitiesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [wvw/matches](https://wiki.guildwars2.com/wiki/API:2/wvw/matches)
```cs
Task<IList<string>> GetAllWvwMatchIdsAsync(CancellationToken token = default);
```
```cs
Task<WvwMatch> GetWvwMatchAsync(int world, CancellationToken token = default);
```
```cs
Task<WvwMatch> GetWvwMatchAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<WvwMatch>> GetWvwMatchesAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<WvwMatch>> GetAllWvwMatchesAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<WvwMatch>>> GetWvwMatchesAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [wvw/matches/overview](https://wiki.guildwars2.com/wiki/API:2/wvw/matches)
```cs
Task<IList<string>> GetAllWvwOverviewIdsAsync(CancellationToken token = default);
```
```cs
Task<WvwOverview> GetWvwOverviewAsync(int world, CancellationToken token = default);
```
```cs
Task<WvwOverview> GetWvwOverviewAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<WvwOverview>> GetWvwOverviewsAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<WvwOverview>> GetAllWvwOverviewsAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<WvwOverview>>> GetWvwOverviewsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [wvw/matches/scores](https://wiki.guildwars2.com/wiki/API:2/wvw/matches)
```cs
Task<IList<string>> GetAllWvwScoreIdsAsync(CancellationToken token = default);
```
```cs
Task<WvwScore> GetWvwScoreAsync(int world, CancellationToken token = default);
```
```cs
Task<WvwScore> GetWvwScoreAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<WvwScore>> GetWvwScoresAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<WvwScore>> GetAllWvwScoresAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<WvwScore>>> GetWvwScoresAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [wvw/matches/stats](https://wiki.guildwars2.com/wiki/API:2/wvw/matches)
```cs
Task<IList<string>> GetAllWvwStatsIdsAsync(CancellationToken token = default);
```
```cs
Task<WvwStats> GetWvwStatsAsync(int world, CancellationToken token = default);
```
```cs
Task<WvwStats> GetWvwStatsAsync(string id, CancellationToken token = default);
```
```cs
Task<IList<WvwStats>> GetWvwStatsAsync(IEnumerable<string> ids, CancellationToken token = default);
```
```cs
Task<IList<WvwStats>> GetAllWvwStatsAsync(CancellationToken token = default);
```
```cs
Task<Page<IList<WvwStats>>> GetWvwStatsAsync(int page = 0, int pageSize = -1, CancellationToken token = default);
```

### [wvw/objectives](https://wiki.guildwars2.com/wiki/API:2/wvw/objectives)
```cs
Task<IList<string>> GetAllWvwObjectiveIdsAsync(CancellationToken token = default);
```
```cs
Task<WvwObjective> GetWvwObjectiveAsync(string id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<WvwObjective>> GetWvwObjectivesAsync(IEnumerable<string> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<WvwObjective>> GetAllWvwObjectivesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<WvwObjective>>> GetWvwObjectivesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [wvw/ranks](https://wiki.guildwars2.com/wiki/API:2/wvw/ranks)
```cs
Task<IList<int>> GetAllWvwRankIdsAsync(CancellationToken token = default);
```
```cs
Task<WvwRank> GetWvwRankAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<WvwRank>> GetWvwRanksAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<WvwRank>> GetAllWvwRanksAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<WvwRank>>> GetWvwRanksAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```

### [wvw/upgrades](https://wiki.guildwars2.com/wiki/API:2/wvw/upgrades)
```cs
Task<IList<int>> GetAllWvwUpgradeIdsAsync(CancellationToken token = default);
```
```cs
Task<WvwUpgrade> GetWvwUpgradeAsync(int id, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<WvwUpgrade>> GetWvwUpgradesAsync(IEnumerable<int> ids, CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<IList<WvwUpgrade>> GetAllWvwUpgradesAsync(CultureInfo lang = null, CancellationToken token = default);
```
```cs
Task<Page<IList<WvwUpgrade>>> GetWvwUpgradesAsync(int page = 0, int pageSize = -1, CultureInfo lang = null, CancellationToken token = default);
```
