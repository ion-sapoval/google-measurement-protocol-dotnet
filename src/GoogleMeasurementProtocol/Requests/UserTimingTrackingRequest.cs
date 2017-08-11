using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class UserTimingTrackingRequest : RequestBase
    {
        [Obsolete("Google is supporting now only https protocol. Parameter useSsl doesn't have any effect.")]
        public UserTimingTrackingRequest(bool useSsl = false, IWebProxy proxy = null) : this(proxy)
        {
        }

        public UserTimingTrackingRequest(IWebProxy proxy = null) : base(proxy)
        {
            HitType = HitTypes.Timing;
            Parameters.Add(new HitType(HitTypes.Timing));
        }
    }
}
