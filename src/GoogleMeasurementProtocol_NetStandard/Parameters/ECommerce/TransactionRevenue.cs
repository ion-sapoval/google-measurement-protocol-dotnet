using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
   /// <summary>
    /// Specifies the total revenue associated with the transaction.
    /// This value should include any shipping or tax costs.
   /// </summary>
    public class TransactionRevenue : Parameter
    {
        public TransactionRevenue(decimal value)
            : base(value)
        {
        }

        public override string Name => "tr";

       public override List<string> SupportedHitTypes => new List<string> { HitTypes.Transaction };

       public override Type ValueType => typeof(decimal);
    }
}
