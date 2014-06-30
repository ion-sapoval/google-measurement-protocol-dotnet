namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// A product-level custom dimesion where index is a positive integer between 0 and 200.
    /// </summary>
    public class ProductImpressionCustomDimension : Parameter
    {
        public ProductImpressionCustomDimension(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]cd[index]"; }
        }
    }
}
