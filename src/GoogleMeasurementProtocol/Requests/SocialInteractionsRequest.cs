using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.Hit;
using GoogleMeasurementProtocol.Parameters.SocialInteractions;

namespace GoogleMeasurementProtocol.Requests
{
    public class SocialInteractionsRequest : RequestBase
    {
        public SocialInteractionsRequest(bool useSsl = false, IWebProxy proxy = null)
            : base(useSsl, proxy)
        {
            HitType = HitTypes.Social;
            Parameters.Add(new HitType(HitTypes.Social));
        }

        protected override void ValidateRequestParams()
        {
            base.ValidateRequestParams();

            if (!Parameters.Exists(p => p is SocialAction))
            {
                throw new ApplicationException("SocialAction parameter is missing.");
            }

            if (!Parameters.Exists(p => p is SocialNetwork))
            {
                throw new ApplicationException("SocialNetwork parameter is missing.");
            }

            if (!Parameters.Exists(p => p is SocialActionTarget))
            {
                throw new ApplicationException("SocialActionTarget parameter is missing.");
            }
        }
    }
}
