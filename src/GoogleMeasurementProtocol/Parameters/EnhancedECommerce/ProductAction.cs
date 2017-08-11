namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The role of the products included in a hit. If a product action is not specified, all product definitions included with the hit will be ignored.
    /// Must be one of: detail, click, add, remove, checkout, checkout_option, purchase, refund.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductAction : Parameter
    {
        public ProductAction(string value)
            : base(value)
        {
        }

        public override string Name => @"pa";
    }
}
