namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The SKU of the product. For analytics.js 
    /// the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductSku : Parameter
    {
        public ProductSku(string value) : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]id"; }
        }
    }
}
