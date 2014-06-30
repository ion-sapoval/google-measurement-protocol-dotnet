namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The name of the product.
    /// </summary>
    public class ProductImpressionName : Parameter
    {
        public ProductImpressionName(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]nm"; }
        }
    }
}
