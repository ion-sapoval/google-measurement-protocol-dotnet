using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The price of a product.
   /// </summary>
    public class ProductImpressionPrice : Parameter
    {
        public ProductImpressionPrice(decimal value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]pr"; }
        }

        public override Type ValueType
        {
            get { return typeof(decimal); }
        }
    }
}
