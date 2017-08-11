namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// Specifies the role of the promotions included in a hit.
    /// If a promotion action is not specified, the default promotion action, 'view', is assumed. To measure a user click on a promotion set this to 'promo_click'. 
   /// </summary>
    public class PromotionAction : Parameter
    {
        public PromotionAction(string value)
            : base(value)
        {
        }

        public override string Name => @"promoa";
    }
}
