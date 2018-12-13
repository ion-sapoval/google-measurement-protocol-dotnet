using System.Net.Http;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ExceptionTrackingRequest : RequestBase
    {
        public ExceptionTrackingRequest(HttpClient httpClient) : base(httpClient)
        {
            HitType = HitTypes.Exception;
            Parameters.Add(new HitType(HitTypes.Exception));
        }
    }
}
