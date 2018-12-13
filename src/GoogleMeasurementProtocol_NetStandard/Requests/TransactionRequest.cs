using System;
using System.Net.Http;
using GoogleMeasurementProtocol.Parameters.ECommerce;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class TransactionRequest : RequestBase
    {
        public TransactionRequest(HttpClient httpClient) : base(httpClient)
        {
            HitType = HitTypes.Transaction;
            Parameters.Add(new HitType(HitTypes.Transaction));
        }

        protected override void ValidateRequestParams()
        {
            base.ValidateRequestParams();

            if (!Parameters.Exists(p => p is TransactionId))
            {
                throw new ApplicationException("TransactionId parameter is missing.");
            }
        }
    }
}
