using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ScreenTrackingRequest : RequestBase
    {
        [Obsolete("Google is supporting now only https protocol. Parameter useSsl doesn't have any effect.")]
        public ScreenTrackingRequest(bool useSsl = false, IWebProxy proxy = null) : this(proxy)
        {
        }

        public ScreenTrackingRequest(IWebProxy proxy = null) : base(proxy)
        {
            HitType = HitTypes.ScreenView;
            Parameters.Add(new HitType(HitTypes.ScreenView));
        }
    }
}
