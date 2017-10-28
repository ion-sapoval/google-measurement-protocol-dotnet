using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The total tax associated with the transaction. This is an additional parameter that can be sent when Product Action is set to 'purchase' or 'refund'.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
   /// </summary>
    public class Tax : Parameter
    {
        public Tax(decimal value)
            : base(value)
        {
        }

        public override string Name => "tt";

        public override Type ValueType => typeof(decimal);
    }
}
