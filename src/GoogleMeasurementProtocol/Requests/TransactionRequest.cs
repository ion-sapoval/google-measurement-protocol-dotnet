using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.ECommerce;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class TransactionRequest : RequestBase
    {
        [Obsolete("Google is supporting now only https protocol. Parameter useSsl doesn't have any effect.")]
        public TransactionRequest(bool useSsl = false, IWebProxy proxy = null) : this(proxy)
        {
        }

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
