using GW2Api.NET.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Files
{
    [TestClass, TestCategory("Large"), TestCategory("Files")]
    public class FilesTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup() => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllFilesAsync_NoParameters_ReturnsFilesWithFileNames()
        {
            var files = await _api.GetAllFilesAsync();

            Assert.IsTrue(files.Any());
            files.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Name));
        }

        [TestMethod]
        public async Task GetAllFilesAsync_CancellationToken_ReturnsFilesWithFileNames()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var files = await _api.GetAllFilesAsync(cts.Token);

            Assert.IsTrue(files.Any());
            files.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Name));
        }
    }
}
