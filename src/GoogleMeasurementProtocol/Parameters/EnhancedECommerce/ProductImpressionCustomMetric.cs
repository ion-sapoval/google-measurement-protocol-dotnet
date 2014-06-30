using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// A product-level custom metric where index is a positive integer between 0 and 200.
    /// </summary>
    public class ProductImpressionCustomMetric : Parameter
    {
        public ProductImpressionCustomMetric(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]cm"; }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }
}
