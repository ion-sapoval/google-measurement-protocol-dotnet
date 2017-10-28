using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The name of the promotion. 
   /// </summary>
    public class PromotionName : Parameter
    {
        public byte PromoIndex { get; set; }

        public PromotionName(string value, byte promoIndex = 1)
            : base(value)
        {
            PromoIndex = promoIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidatePromotionIndex(PromoIndex);

                return $"promo{PromoIndex}nm";
            }
        }
    }
}
