namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The brand associated with the product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductBrand : Parameter
    {
        public ProductBrand(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]br"; }
        }
    }
}
