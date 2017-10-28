using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The coupon code associated with a product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductCouponCode : Parameter
    {
        public byte ProductIndex { get; set; }

        public ProductCouponCode(string value)
            : base(value)
        {
            ProductIndex = 1;
        }

        public ProductCouponCode(string value, byte productIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);

                return $"pr{ProductIndex}cc"; 
            }
        }
    }
}
