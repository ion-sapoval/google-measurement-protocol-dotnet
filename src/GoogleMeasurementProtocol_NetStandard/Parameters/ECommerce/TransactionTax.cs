using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// Specifies the total tax of the transaction.
    /// </summary>
    public class TransactionTax : Parameter
    {
        public TransactionTax(decimal value)
            : base(value)
        {
        }

        public override string Name => "tt";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Transaction };

        public override Type ValueType => typeof(decimal);
    }
}
