using GW2Api.NET.IntegrationTests.V2.Accounts;

namespace GW2Api.NET.IntegrationTests.V2.Config
{
    public record TestConfig
    {
        public string ApiKey { get; set; }
        public AccountTestConfig AccountTestConfig { get; set; }
    }
}
