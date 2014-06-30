namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The promotion ID. 
    /// </summary>
    public class PromotionId : Parameter
    {
        public PromotionId(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return @"promo[\d+]id"; }
        }
    }
}
