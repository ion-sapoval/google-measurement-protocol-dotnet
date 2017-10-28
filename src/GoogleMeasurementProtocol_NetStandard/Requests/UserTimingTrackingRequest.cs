using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class UserTimingTrackingRequest : RequestBase
    {
        public UserTimingTrackingRequest(IWebProxy proxy = null) : base(proxy)
        {
            HitType = HitTypes.Timing;
            Parameters.Add(new HitType(HitTypes.Timing));
        }
    }
}
