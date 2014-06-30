using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// Specifies the total shipping cost of the transaction.
    /// </summary>
    public class TransactionShipping : Parameter
    {
        public TransactionShipping(decimal value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "ts"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Transaction }; }

        }

        public override Type ValueType
        {
            get
            {
                return typeof(decimal);
            }
        }
    }
}
