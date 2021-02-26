using GW2Api.NET.V1;
using GW2Api.NET.V1.Events.Dto.Locations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace GW2Api.NET.IntegrationTests.V1.Events
{
    [TestClass, TestCategory("Large"), TestCategory("Events")]
    public class EventsTests
    {
        private IGw2ApiV1 _api;

        [TestInitialize]
        public void Setup() => _api = new Gw2ApiV1(new HttpClient());

        [TestMethod]
        public async Task GetAllAvailableEventsDetailsAsync_NoParams_GetsAllEventDetailsWithFileIds()
        {
            var eventDetails = await _api.GetAllAvailableEventsDetailsAsync();

            Assert.IsTrue(eventDetails.Any());
            eventDetails.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Id));
        }

        [TestMethod]
        public async Task GetAllAvailableEventsDetailsAsync_CancellationToken_GetsAllEventDetailsWithFileIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var eventDetails = await _api.GetAllAvailableEventsDetailsAsync(token: cts.Token);

            Assert.IsTrue(eventDetails.Any());
            eventDetails.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Id));
        }

        [TestMethod]
        [DataRow(typeof(PolygonLocation))]
        [DataRow(typeof(SphereLocation))]
        [DataRow(typeof(CylinderLocation))]
        public async Task GetEventDetailAsync_ValidEventId_GetsThatOneEvent(Type type)
        {
            var eventId = (await _api.GetAllAvailableEventsDetailsAsync())
                .First(x => x.Value.Location.GetType() == type)
                .Value
                .Id;

            var eventDetail = await _api.GetEventDetailAsync(eventId);

            Assert.AreEqual(eventId, eventDetail.Id);
            Assert.AreEqual(eventDetail.Location.GetType(), type);
        }

        [TestMethod]
        public async Task GetEventDetailAsync_InValidEventId_Throws400()
        {
            var ex = await Assert.ThrowsExceptionAsync<HttpRequestException>(() =>
                _api.GetEventDetailAsync(Guid.NewGuid())
            );

            Assert.AreEqual(HttpStatusCode.BadRequest, ex.StatusCode);
        }
    }
}
