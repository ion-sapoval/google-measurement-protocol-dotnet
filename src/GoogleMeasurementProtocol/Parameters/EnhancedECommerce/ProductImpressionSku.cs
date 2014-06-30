namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The product ID or SKU.
    /// </summary>
    public class ProductImpressionSku : Parameter
    {
        public ProductImpressionSku(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]pi[\d+]id"; }
        }
    }
}
