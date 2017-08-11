using System;
using System.Collections.Generic;
using GoogleMeasurementProtocol;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.General;
using GoogleMeasurementProtocol.Parameters.User;
using GoogleMeasurementProtocol.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Test_GoogleAnalyticsRequestFactory
{
    [TestClass]
    public class CreateRequest
    {
        private GoogleAnalyticsRequestFactory _genericFactory = new GoogleAnalyticsRequestFactory("test");

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_throw_exception_if_hitType_is_not_set()
        {
            _genericFactory.CreateRequest(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void Should_throw_exception_if_hitType_is_not_supported()
        {
            _genericFactory.CreateRequest("unsupported");
        }

        [TestMethod]
        public void Should_create_a_request_of_type_EventRequest()
        {
            var request = _genericFactory.CreateRequest(HitTypes.Event);

            Assert.IsTrue(request is EventRequest);
        }

        [TestMethod]
        public void Any_created_request_should_have_trackingId_param()
        {
            var request = _genericFactory.CreateRequest(HitTypes.Event);

            Assert.IsTrue(request.Parameters.Exists(p=>p is TrackingId));
        }

        [TestMethod]
        public void Any_created_request_should_have_protocolVersion_param()
        {
            var request = _genericFactory.CreateRequest(HitTypes.Social);

            Assert.IsTrue(request.Parameters.Exists(p => p is ProtocolVersion));
        }

        [TestMethod]
        public void Provided_userId_request_param_should_be_associated_to_the_request()
        {
            var request = _genericFactory.CreateRequest(HitTypes.Social, new List<Parameter>{new UserId("test")});

            Assert.IsTrue(request.Parameters.Exists(p => p is UserId && p.Value.Equals("test")));
        }
    }
}
