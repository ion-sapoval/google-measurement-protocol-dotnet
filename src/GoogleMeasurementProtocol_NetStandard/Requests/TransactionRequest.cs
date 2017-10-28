using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.ECommerce;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class TransactionRequest : RequestBase
    {
        public TransactionRequest(IWebProxy proxy = null) : base(proxy)
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
