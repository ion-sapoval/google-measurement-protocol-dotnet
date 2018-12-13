using System;
using System.Net.Http;
using GoogleMeasurementProtocol.Parameters.ContentInformation;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class PageViewRequest : RequestBase
    {
        public PageViewRequest(HttpClient httpClient) : base(httpClient)
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
