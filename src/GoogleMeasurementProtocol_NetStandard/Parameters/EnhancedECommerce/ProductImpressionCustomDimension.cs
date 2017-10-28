using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// A product-level custom dimesion where index is a positive integer between 0 and 200.
    /// </summary>
    public class ProductImpressionCustomDimension : Parameter
    {
       public byte ProductIndex { get; set; }

        public byte ListIndex { get; set; }

        public byte DimensionIndex { get; set; }

        public ProductImpressionCustomDimension(string value, byte productIndex = 1, byte listIndex = 1, byte dimensionIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
            ListIndex = listIndex;
            DimensionIndex = dimensionIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);
                IndexValidator.ValidateListIndex(ListIndex);
                IndexValidator.ValidateDimensionIndex(DimensionIndex);

                return $"il{ListIndex}pi{ProductIndex}cd{DimensionIndex}";
            }
        }
    }
}
