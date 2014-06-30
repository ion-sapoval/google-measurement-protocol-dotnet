namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The category to which the product belongs. 
    /// </summary>
    public class ProductImpressionCategory : Parameter
    {
        public ProductImpressionCategory(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]ca"; }
        }
    }
}
