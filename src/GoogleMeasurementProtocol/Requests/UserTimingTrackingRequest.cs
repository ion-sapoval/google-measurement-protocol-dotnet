using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class UserTimingTrackingRequest : RequestBase
    {
        public UserTimingTrackingRequest(bool useSsl = false, IWebProxy proxy = null)
            : base(useSsl, proxy)
        {
            HitType = HitTypes.Timing;
            Parameters.Add(new HitType(HitTypes.Timing));
        }
    }
}
