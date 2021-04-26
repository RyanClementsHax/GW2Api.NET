using GW2Api.NET.IntegrationTests.V2.Accounts;
using GW2Api.NET.IntegrationTests.V2.Characters;
using GW2Api.NET.IntegrationTests.V2.Guilds;
using GW2Api.NET.IntegrationTests.V2.Pvp;

namespace GW2Api.NET.IntegrationTests.V2.Config
{
    public record TestConfig
    {
        public string ApiKey { get; set; }
        public AccountTestConfig AccountTestConfig { get; set; }
        public CharactersTestConfig CharactersTestConfig { get; set; }
        public PvpTestConfig PvpTestConfig { get; set; }
        public GuildsTestConfig GuildsTestConfig { get; set; }
    }
}
