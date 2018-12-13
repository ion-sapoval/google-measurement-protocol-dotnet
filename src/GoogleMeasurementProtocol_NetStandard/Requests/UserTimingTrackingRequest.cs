using System.Net.Http;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class UserTimingTrackingRequest : RequestBase
    {
        public UserTimingTrackingRequest(HttpClient httpClient) : base(httpClient)
        {
            HitType = HitTypes.Timing;
            Parameters.Add(new HitType(HitTypes.Timing));
        }
    }
}
