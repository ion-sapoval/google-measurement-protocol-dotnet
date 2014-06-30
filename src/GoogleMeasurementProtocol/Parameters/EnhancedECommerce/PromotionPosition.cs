namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The position of the creative.
    /// </summary>
    public class PromotionPosition : Parameter
    {
        public PromotionPosition(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"promo[\d+]ps"; }
        }
    }
}
