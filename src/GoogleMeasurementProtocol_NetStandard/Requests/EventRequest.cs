using System;
using System.Net.Http;
using GoogleMeasurementProtocol.Parameters.EventTracking;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class EventRequest : RequestBase
    {
        public EventRequest(HttpClient httpClient) : base(httpClient)
        {
            HitType = HitTypes.Event;
            Parameters.Add(new HitType(HitTypes.Event));
        }

        protected override void ValidateRequestParams()
        {
            base.ValidateRequestParams();

            if (!Parameters.Exists(p => p is EventCategory))
            {
                throw new ApplicationException("EventCategory parameter is missing.");
            }

            if (!Parameters.Exists(p => p is EventAction))
            {
                throw new ApplicationException("EventAction parameter is missing.");
            }
        }
    }
}
