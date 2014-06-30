using System;
using System.Net;
using GoogleMeasurementProtocol.Parameters.ECommerce;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ItemRequest : RequestBase
    {
        public ItemRequest(bool useSsl = false, IWebProxy proxy = null)
            : base(useSsl, proxy)
        {
            HitType = HitTypes.Item;
            Parameters.Add(new HitType(HitTypes.Item));
        }

        protected override void ValidateRequestParams()
        {
            base.ValidateRequestParams();

            if (!Parameters.Exists(p => p is TransactionId))
            {
                throw new ApplicationException("TransactionId parameter is missing.");
            }

            if (!Parameters.Exists(p => p is ItemName))
            {
                throw new ApplicationException("ItemName parameter is missing.");
            }
        }
    }
}
