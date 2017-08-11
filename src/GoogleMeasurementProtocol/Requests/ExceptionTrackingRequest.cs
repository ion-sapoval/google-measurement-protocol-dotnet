using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ExceptionTrackingRequest : RequestBase
    {
        [Obsolete("Google is supporting now only https protocol. Parameter useSsl doesn't have any effect.")]
        public ExceptionTrackingRequest(bool useSsl = false, IWebProxy proxy = null) : this(proxy)
        {
        }

        public ExceptionTrackingRequest(IWebProxy proxy = null): base(proxy)
        {
            HitType = HitTypes.Exception;
            Parameters.Add(new HitType(HitTypes.Exception));
        }
    }
}
