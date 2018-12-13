using System;
using System.Net.Http;
using GoogleMeasurementProtocol.Parameters.ECommerce;
using GoogleMeasurementProtocol.Parameters.Hit;

namespace GoogleMeasurementProtocol.Requests
{
    public class ItemRequest : RequestBase
    {
        public ItemRequest(HttpClient httpClient) : base(httpClient)
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
