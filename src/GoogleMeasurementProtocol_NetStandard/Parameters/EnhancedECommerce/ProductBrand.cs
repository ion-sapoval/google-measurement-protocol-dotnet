using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The brand associated with the product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductBrand : Parameter
    {
        public byte ProductIndex { get; set; }

        public ProductBrand(string value, byte productIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);

                return $"pr{ProductIndex}br";
            }
        }
    }
}
