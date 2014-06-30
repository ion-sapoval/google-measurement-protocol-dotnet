namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The variant of the product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductVariant : Parameter
    {
        public ProductVariant(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]va"; }
        }
    }
}
