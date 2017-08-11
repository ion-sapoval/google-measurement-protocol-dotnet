using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.ContentInformation;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class PageViewRequest : RequestBase
    {
        [Obsolete("Google is supporting now only https protocol. Parameter useSsl doesn't have any effect.")]
        public PageViewRequest(bool useSsl = false, IWebProxy proxy = null) : this(proxy)
        {
        }

        public PageViewRequest(IWebProxy proxy = null) : base(proxy)
        {
            HitType = HitTypes.PageView;
            Parameters.Add(new HitType(HitTypes.PageView));
        }

        protected override void ValidateRequestParams()
        {
            base.ValidateRequestParams();

            if (!Parameters.Exists(p => p is DocumentPath))
            {
                throw new ApplicationException("DocumentPath parameter is missing.");
            }
        }
    }
}
