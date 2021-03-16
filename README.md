# GW2Api.NET

This is a C# wrapper around `https://api.guildwars2.com/` written as a dotnet core library. This is a work in progress, but feel free to try out!

## V2

### Usage
All you have to do is instantiate an instance of `Gw2ApiV2` with an `HttpClient` to start using!
```cs
IGw2ApiV2 api = new Gw2ApiV2(new HttpClient());
```

### Accessing authenticated endpoints
To access authenticated endpoints, you need to create an [Api Key](https://wiki.guildwars2.com/wiki/API:API_key) with the permissions you desire. You have two ways of setting the Api Key.
1. Set the `ApiKey` property of the `Gw2ApiV2` instance you create. This will serve as the default Api Key for all authenticated requests you use on this instance.
    ```cs
    var api = new Gw2ApiV2(new HttpClient())
    {
        ApiKey = "<the api key>"
    };

    var result = await api.GetAccountAsync();
    ```
1. Pass it in as an argument to the function you want to call (only functions that access authenticated resources will have this paramater exposed). This key will be used over any key that is set to the `ApiKey` property.
    ```cs
    var api = new Gw2ApiV2(new HttpClient());

    var result = await api.GetAccountAsync("<the api key>");
    ```
Note that if no Api Keys are given, calling functions that need authentication will result in 401 Unauthenticated exceptions thrown.

## Development

### Running authenticated integration tests
1. Create an [Api Key](https://wiki.guildwars2.com/wiki/API:API_key) with Arena Net and give it all permissions
2. Create a `v2.config.json` in the `GW2Api.NET.IntegrationTests` folder and fill it with data from an account for the tests to assert on
    ```json
    {
      "ApiKey": "<the api key>",
      "AccountTestConfig": {
        "Name": "Creed.5670",
        "AchievementIds": [ 1, 2, 3 ],
        "DailyCraftingIds": [],
        "DungeonIds": [],
        "DyeIds": [ 1634, 1640, 1649 ],
        "FinisherIds": [ 1, 2, 62 ],
        "GliderIds": [ 78 ],
        "HomeCatIds": [],
        "HomeNodeIds": [ "bandit_chest" ],
        "SharedInventoryItemIds": [ 78599 ],
        "MailCarrierIds": [ 4, 15 ],
        "MapChestIds": [],
        "MasteryIds": [ 1, 2, 3 ],
        "MasteryPointSummaryData": {
          "Regions": [ "Tyria", "Desert" ],
          "MasteryIds": [ 1, 3, 4 ]
        },
        "MinisIds": [ 76, 118, 129 ],
        "MountSkinIds": [ 1 ],
        "MountTypes": [ "raptor" ],
        "NoveltyIds": [],
        "OutfitIds": [ 27, 52 ],
        "PvpHeroIds": [ 3 ],
        "RaidIds": [],
        "RecipeIds": [ 104, 105, 106 ],
        "SkinIds": [ 1, 2, 3 ],
        "TitleIds": [ 11, 12, 13 ],
        "CurrencyIds": [ 1, 2, 3 ],
        "WorldBossIds": []
      }
    }
    ```
    - `ApiKey`: The Api Key to use in the tests (should have all permissions)
    - `AccountConfig`
        - `Name`: The account's name
        - `AchievementIds`: A list of ids of some of the achievements the account has
        - `DailyCraftingIds`: A list of ids of some of the time gated crafting ids the account has completed today
        - `DungeonIds`: A list of ids of some of the dungeons account has completed today
        - `DyeIds`: A list of ids of some of the dyes the account has
        - `FinisherIds`: A list of ids of some of the finishers the account has
        - `GliderIds`: A list of ids of some of the gliders the account has
        - `HomeCatIds`: A list of ids of some of the cats in the home instance the account has unlocked
        - `HomeNodeIds`: A list of ids of some of the nodes home instance the account has unlocked
        - `SharedInventoryItemIds`: A list of ids of some of the items in the shared inventory slots
        - `MailCarrierIds`: A list ids of some of the mail carriers the account has unlocked
        - `MapChestIds`: A list ids of some of the map chests the account has unlocked today
        - `MasteryIds`: A list ids of some of the masteries account has unlocked
        - `MasteryPointSummaryData`
          - `Regions`: A list of some regions you have mastery points in
          - `MasteryIds`: A list of ids of some unlocked mastery points the account has unlocked
        - `MinisIds`: A list of ids of some mini pets the account has unlocked
        - `MountSkinIds`: A list of ids of some of the mount skins the account has unlocked
        - `MountTypes`: A list of ids of some of the mount types the account has unlocked
        - `NoveltyIds`: A list of ids of some of the novelties the account has unlocked
        - `OutfitIds`: A list of ids of some of the outfits the account has unlocked
        - `PvpHeroIds`: A list of ids of some of the pvp heros the account has unlocked
        - `RaidIds`: A list of some of the raids the account has completed since the last weekly raid reset
        - `RecipeIds`: A list of ids of some of the recipes the account has unlocked
        - `SkinIds`: A list of ids of some of the skins the account has unlocked
        - `TitleIds`: A list of ids of some of the titles the account has unlocked
        - `CurrencyIds`: A list of ids of some of the currencies the account has
        - `WorldBossIds`: A list of ids of some of the world bosses killed by the account today
    - You can acquire the data to populate this json by manually hitting the endpoints with the api key
    - Note that in the authenticated tests, we use partial matching of data to avoid brittle tests because account data is changing if the acccount is being used or played on
        - For example, we dont want to assert that the ids we get back from fetching all account achievement ids is exactly equal to some fixed set of numbers because that account could complete another achievement later down the road thus breaking the assertion even though the function works as it should
3. Run the authenticated tests in visual studio
