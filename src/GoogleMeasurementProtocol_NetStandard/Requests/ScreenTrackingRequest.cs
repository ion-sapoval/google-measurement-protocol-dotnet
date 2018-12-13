using System.Net.Http;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ScreenTrackingRequest : RequestBase
    {
        public ScreenTrackingRequest(HttpClient httpClient) : base(httpClient)
        {
            HitType = HitTypes.ScreenView;
            Parameters.Add(new HitType(HitTypes.ScreenView));
        }
    }
}
