using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The product's position in a list or collection.
    /// </summary>
    public class ProductImpressionPosition : Parameter
    {
        public ProductImpressionPosition(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]ps"; }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }
}
