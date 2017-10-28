using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The name of the product.
    /// </summary>
    public class ProductImpressionName : Parameter
    {
        public byte ProductIndex { get; set; }

        public byte ListIndex { get; set; }

        public ProductImpressionName(string value, byte productIndex = 1, byte listIndex = 1)
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

                return $"il{ListIndex}pi{ProductIndex}nm";
            }
        }
    }
}
