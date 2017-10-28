using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    ///The total value of the transaction, including tax and shipping. If not sent, this value will be automatically calculated using the product quantity and price fields
    /// of all products in the same hit. This is an additional parameter that can be sent when Product Action is set to 'purchase' or 'refund'.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field. 
    /// </summary>
    public class Revenue : Parameter
    {
        public Revenue(decimal value)
            : base(value)
        {
        }

        public override string Name => "tr";

        public override Type ValueType => typeof(decimal);
    }
}
