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

        public override string Name
        {
            get { return "tt"; }
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
