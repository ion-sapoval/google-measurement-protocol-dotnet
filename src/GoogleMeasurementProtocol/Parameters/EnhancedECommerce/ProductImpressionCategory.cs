using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The category to which the product belongs. 
    /// </summary>
    public class ProductImpressionCategory : Parameter
    {
        public byte ProductIndex { get; set; }

        public byte ListIndex { get; set; }

        public ProductImpressionCategory(string value, byte productIndex = 1, byte listIndex = 1)
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

                return $"il{ListIndex}pi{ProductIndex}ca";
            }
        }
    }
}
