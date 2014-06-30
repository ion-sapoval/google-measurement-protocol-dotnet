namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// A product-level custom dimesion where index is a positive integer between 0 and 200.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductCustomDimension : Parameter
    {
        public ProductCustomDimension(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]cd[index]"; }
        }
    }
}
