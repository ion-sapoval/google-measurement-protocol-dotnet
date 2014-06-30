using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// A product-level custom metric where index is a positive integer between 0 and 200.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
   /// </summary>
    public class ProductCustomMetric : Parameter
    {
        public ProductCustomMetric(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]cm[index]"; }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }

}
