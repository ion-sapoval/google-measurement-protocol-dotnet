namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The creative associated with the promotion.
    /// </summary>
    public class PromotionCreative : Parameter
    {
        public PromotionCreative(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"promo[\d+]cr"; }
        }
    }
}
