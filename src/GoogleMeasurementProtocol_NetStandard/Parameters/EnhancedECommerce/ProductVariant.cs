using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The variant of the product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductVariant : Parameter
    {
       public byte ProductIndex { get; set; }

       public ProductVariant(string value, byte productIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);

                return $"pr{ProductIndex}va";
            }
        }
    }
}
