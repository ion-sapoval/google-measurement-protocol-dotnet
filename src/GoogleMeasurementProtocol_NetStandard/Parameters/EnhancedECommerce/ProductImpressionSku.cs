using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The product ID or SKU.
    /// </summary>
    public class ProductImpressionSku : Parameter
    {
        public byte ProductIndex { get; set; }

        public byte ListIndex { get; set; }

        public ProductImpressionSku(string value, byte productIndex = 1, byte listIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
            ListIndex = listIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);
                IndexValidator.ValidateListIndex(ListIndex);

                return $"il{ListIndex}pi{ProductIndex}id";
            }
        }
    }
}
