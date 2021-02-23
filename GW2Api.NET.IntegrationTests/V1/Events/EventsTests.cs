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
        public void Setup()
        {
            _api = new Gw2ApiV1(new HttpClient());
        }

        [TestMethod]
        public async Task GetAllAvailableEventsDetails_NoParams_GetsAllEventDetailsWithFileIds()
        {
            var eventDetails = await _api.GetAllAvailableEventsDetails();

            Assert.IsTrue(eventDetails.Any());
            eventDetails.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Id));
        }

        [TestMethod]
        public async Task GetAllAvailableEventsDetails_CancellationToken_GetsAllEventDetailsWithFileIds()
        {
            using var cts = TestData.CreateDefaultTokenSource();

            var eventDetails = await _api.GetAllAvailableEventsDetails(token: cts.Token);

            Assert.IsTrue(eventDetails.Any());
            eventDetails.ToList().ForEach(x => Assert.AreEqual(x.Key, x.Value.Id));
        }

        [TestMethod]
        [DataRow(typeof(PolygonLocation))]
        [DataRow(typeof(SphereLocation))]
        [DataRow(typeof(CylinderLocation))]
        public async Task GetEventDetail_ValidEventId_GetsThatOneEvent(Type type)
        {
            var eventId = (await _api.GetAllAvailableEventsDetails())
                .First(x => x.Value.Location.GetType() == type)
                .Value
                .Id;

            var eventDetail = await _api.GetEventDetail(eventId);

            Assert.AreEqual(eventId, eventDetail.Id);
            Assert.AreEqual(eventDetail.Location.GetType(), type);
        }

        [TestMethod]
        public async Task GetEventDetail_InValidEventId_Throws400()
        {
            var ex = await Assert.ThrowsExceptionAsync<HttpRequestException>(() =>
                _api.GetEventDetail(Guid.NewGuid())
            );

            Assert.AreEqual(HttpStatusCode.BadRequest, ex.StatusCode);
        }
    }
}
