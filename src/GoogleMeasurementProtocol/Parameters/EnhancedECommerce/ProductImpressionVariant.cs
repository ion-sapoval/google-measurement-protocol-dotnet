namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The variant of the product.
   /// </summary>
    public class ProductImpressionVariant : Parameter
    {
        public ProductImpressionVariant(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]ca"; }
        }
    }
}
