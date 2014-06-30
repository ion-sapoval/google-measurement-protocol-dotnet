namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The category to which the product belongs. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductCategory : Parameter
    {
        public ProductCategory(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]ca"; }
        }
    }
}
