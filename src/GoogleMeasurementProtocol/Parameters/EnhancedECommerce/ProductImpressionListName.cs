namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The list or collection to which a product belongs.
   /// </summary>
    public class ProductImpressionListName : Parameter
    {
        public ProductImpressionListName(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"il[\d+]nm"; }
        }
    }
}
