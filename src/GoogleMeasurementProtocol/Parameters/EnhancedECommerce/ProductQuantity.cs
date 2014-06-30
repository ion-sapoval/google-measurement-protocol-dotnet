using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The quantity of a product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductQuantity : Parameter
    {
        public ProductQuantity(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]qt"; }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }
}
