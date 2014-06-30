using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The product's position in a list or collection. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductPosition : Parameter
    {
        public ProductPosition(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]ps"; }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }
}
