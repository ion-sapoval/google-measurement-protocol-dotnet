namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The name of the product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductName : Parameter
    {
        public ProductName(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]nm"; }
        }
    }
}
