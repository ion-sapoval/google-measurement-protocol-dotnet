using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ExceptionTrackingRequest : RequestBase
    {
        public ExceptionTrackingRequest(IWebProxy proxy = null): base(proxy)
        {
            HitType = HitTypes.Exception;
            Parameters.Add(new HitType(HitTypes.Exception));
        }
    }
}
