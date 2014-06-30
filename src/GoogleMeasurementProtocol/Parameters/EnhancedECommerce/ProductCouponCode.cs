namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The coupon code associated with a product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductCouponCode : Parameter
    {
        public ProductCouponCode(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"pr[\d+]cc"; }
        }
    }
}
