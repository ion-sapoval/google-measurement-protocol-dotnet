using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The SKU of the product. For analytics.js 
    /// the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductSku : Parameter
    {
        public byte ProductIndex { get; set; }

        public ProductSku(string value, byte productIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);

                return $"pr{ProductIndex}id";
            }
        }
    }
}
