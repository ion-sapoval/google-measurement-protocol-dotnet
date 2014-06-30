namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The name of the promotion. 
   /// </summary>
    public class PromotionName : Parameter
    {
        public PromotionName(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"promo[\d+]nm"; }
        }
    }
}
