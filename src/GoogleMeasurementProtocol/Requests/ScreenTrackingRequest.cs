using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ScreenTrackingRequest : RequestBase
    {
        public ScreenTrackingRequest(bool useSsl = false, IWebProxy proxy = null)
            : base(useSsl, proxy)
        {
            HitType = HitTypes.ScreenView;
            Parameters.Add(new HitType(HitTypes.ScreenView));
        }
    }
}
