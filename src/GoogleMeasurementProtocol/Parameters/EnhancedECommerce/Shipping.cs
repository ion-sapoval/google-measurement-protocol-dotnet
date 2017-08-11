using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The shipping cost associated with the transaction. This is an additional parameter that can be sent when Product Action is set to 'purchase' or 'refund'.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class Shipping : Parameter
    {
        public Shipping(decimal value)
            : base(value)
        {
        }

        public override string Name => "ts";

        public override Type ValueType => typeof(decimal);
    }
}
