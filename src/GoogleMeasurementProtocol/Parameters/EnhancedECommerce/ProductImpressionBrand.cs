namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The brand associated with the product.
   /// </summary>
    public class ProductImpressionBrand : Parameter
    {
        public ProductImpressionBrand(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]br"; }
        }
    }
}
