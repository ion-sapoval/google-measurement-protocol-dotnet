using System;
using System.Net.Http;
using GoogleMeasurementProtocol.Parameters.Hit;
using GoogleMeasurementProtocol.Parameters.SocialInteractions;

namespace GoogleMeasurementProtocol.Requests
{
    public class SocialInteractionsRequest : RequestBase
    {
        public SocialInteractionsRequest(HttpClient httpClient) : base(httpClient)
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
