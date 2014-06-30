using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The price of a product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductPrice : Parameter
    {
        public ProductPrice(decimal value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]pr"; }
        }

        public override Type ValueType
        {
            get { return typeof(decimal); }
        }
    }
}
