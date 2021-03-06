# GW2Api.NET

A wrapper around `https://api.guildwars2.com/` written as a dotnet core library

- [GW2Api.NET](#gw2apinet)
  - [Arenanet api documentation](#arenanet-api-documentation)
  - [V2](#v2)
    - [Usage](#usage)
    - [Methods](#methods)
    - [Accessing authenticated endpoints](#accessing-authenticated-endpoints)
  - [V1](#v1)
    - [Usage](#usage-1)
    - [Methods](#methods-1)
  - [Development](#development)
    - [Running authenticated integration tests](#running-authenticated-integration-tests)

## [Arenanet api documentation](https://wiki.guildwars2.com/wiki/API:Main)
- [This](https://wiki.guildwars2.com/wiki/API:Main) is the website of all of their documentation for their api
- The V2 documentation is mostly correct
- Don't trust the V1 documentation
- This documentation specifies that you can provide the option of specifying a schema version with the `v` url parameter, but we hard code this value so that the api can construct static types around it

## V2
This version of the api is much more robust, documented, faster, and easier to reason about the responses. It is _highly_ recommended that you use this version. The api documentation that Arenanet provides is *mostly* correct. There are a few things that they miss or leave out, but I tried to express the entire api with this client regardless.

### Usage
All you have to do is instantiate an instance of `Gw2ApiV2` with an `HttpClient` to start using!
```cs
IGw2ApiV2 api = new Gw2ApiV2(new HttpClient());
```

### Methods
- See the [V2 Client Method Documentation](./docs/v2ClientMethodDocumentation.md#v2-client-method-documentation) for details
- If you see any mistakes, please feel free to open a PR

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

## V1
This is the older version of the api. This is poorly documented, slow, hard to reason about the responses, and has a small feature set. It is only included for legacy reasons. **DO NOT** use this client **unless you HAVE TO**. **DO NOT** trust everything in the documentation that Arenanet provides of this version of the api.

### Usage
All you have to do is instantiate an instance of `Gw2ApiV2` with an `HttpClient` to start using!
```cs
IGw2ApiV1 api = new Gw2ApiV1(new HttpClient());
```

### Methods
- See the [V1 Client Method Documentation](./docs/v1ClientMethodDocumentation.md#v1-client-method-documentation) for details
- If you see any mistakes, please feel free to open a PR

## Development

### Running authenticated integration tests
1. Create an [Api Key](https://wiki.guildwars2.com/wiki/API:API_key) with Arena Net and give it all permissions
2. Create a `v2.config.json` like the one below in the `GW2Api.NET.IntegrationTests` folder and fill it with data from an account for the tests to assert on
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
      },
      "CharactersTestConfig": {
        "Ids": [
          "Creed The Noob",
          "Creeden",
          "Diocletio",
          "Creednub",
          "Dynic",
          "Alegren",
          "Ishmakale",
          "Gavlock",
          "Creed The Engie",
          "Sage Of Cherry"
        ],
        "TotalCharacters": 10,
        "SabConfig": {
          "Id": "Diocletio",
          "ZoneIds": [ 1, 2, 3, 4, 13, 14, 15, 16 ],
          "UnlockIds": [ 3, 6, 9, 12, 18, 31 ],
          "SongIds": []
        }
      },
      "PvpTestConfig": {
        "Ids": [
          "430A4455-03E8-41A9-95DC-30847000C629",
          "8648D3DB-AE7C-4BA7-98F5-2572E955F56C",
          "8A2CBE72-BE64-4B91-9B0A-A82734E03755",
          "B0457632-0068-4D28-BAB2-D97408D91CE4",
          "B3CBF945-A7B1-4E6A-B00C-179C52D024E8",
          "C1ED2924-8404-48B4-92B6-CDEFF1B6D93A",
          "C635113B-5719-4AC9-9DB0-C39ED07E7BE8",
          "CEC0A86C-9D8F-49DE-9B03-3D53143A56BD",
          "ECECBA13-4A96-4344-A03C-D4224F64A3B2",
          "FDD2E7B5-8D29-4576-AE0E-8642B1952535"
        ]
      },
      "GuildsTestConfig": {
        "ApiKey": "<the guild owner's api key>",
        "Id": "8E20055E-DC2C-4353-A9D1-EBDA0E1E3201",
        "MemberNames": [ "LordVexicus.8703", "TechyRiceNinja.6318", "DarkandVol.9384" ],
        "RankIds": [ "Acolyte", "Archon", "Awakened" ],
        "TeamNames": [ "Git Gud Gwyn", "Valar Morghulis", "Aeturnum Immortalis" ],
        "UpgradeIds":  [ 38, 55, 58 ]
      }
    }
    ```
    - `ApiKey`: The Api Key to use in the tests (should have all permissions)
    - `AccountTestConfig`
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
    - `CharactersTestConfig`
      - `Ids`: A list of names of some of the characters the account has
      - `TotalCharacters`: The total number of characters the account has
      - `SabConfig`
        - `Id`: A character of this account that you want to assert against for testing the SAB endpoint
        - `ZoneIds`: A list of ids of some of the SAB zones that character has cleared
        - `UnlockIds`: A list of ids of some SAB unlocks that the character has completed
        - `SongIds`: A list of ids of some of the SAB songs that the character has unlocked
    - `PvpTestConfig`
      - `Ids`: A list of ids of some of the pvp games the account has played
    - `GuildsTestConfig`
      - `ApiKey`: The api key created by the guild owner with the `guilds` permission
      - `Id`: The guild id that the api key has access to
      - `MemberNames`: A list of names of some of the members of the guild
      - `RankIds`: A list of ids of some of the ranks of the guild
      - `TeamNames`: A list of names of some of the teams of the guild
      - `UpgradeIds`: A list of ids of some of the upgrades the guild has
    - You can acquire the data to populate this json by manually hitting the endpoints with the api key
    - Note that in the authenticated tests, we use partial matching of data to avoid brittle tests because account data is changing if the acccount is being used or played on
        - For example, we dont want to assert that the ids we get back from fetching all account achievement ids is exactly equal to some fixed set of numbers because that account could complete another achievement later down the road thus breaking the assertion even though the function works as it should
3. Run the authenticated tests in visual studio
