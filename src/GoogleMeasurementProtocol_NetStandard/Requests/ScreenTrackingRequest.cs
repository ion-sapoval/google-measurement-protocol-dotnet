using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ScreenTrackingRequest : RequestBase
    {
        public ScreenTrackingRequest(IWebProxy proxy = null) : base(proxy)
        {
            HitType = HitTypes.ScreenView;
            Parameters.Add(new HitType(HitTypes.ScreenView));
        }
    }
}
