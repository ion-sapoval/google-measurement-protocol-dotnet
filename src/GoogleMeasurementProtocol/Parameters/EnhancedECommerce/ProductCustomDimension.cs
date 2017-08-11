using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// A product-level custom dimesion where index is a positive integer between 0 and 200.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductCustomDimension : Parameter
    {
        public byte ProductIndex { get; set; }

        public byte DimensionIndex { get; set; }

        public ProductCustomDimension(string value, byte productIndex = 1, byte dimensionIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
            DimensionIndex = dimensionIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);
                IndexValidator.ValidateDimensionIndex(DimensionIndex);

                return $"pr{ProductIndex}cd{DimensionIndex}";
            }
        }
    }
}
