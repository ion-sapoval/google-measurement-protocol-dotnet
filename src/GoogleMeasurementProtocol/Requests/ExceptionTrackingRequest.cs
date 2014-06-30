using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ExceptionTrackingRequest : RequestBase
    {
        public ExceptionTrackingRequest(bool useSsl = false, IWebProxy proxy = null)
            : base(useSsl, proxy)
        {
            HitType = HitTypes.Item;
            Parameters.Add(new HitType(HitTypes.Item));
        }
    }
}
