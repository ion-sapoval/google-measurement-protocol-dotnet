using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The creative associated with the promotion.
    /// </summary>
    public class PromotionCreative : Parameter
    {
        public byte PromoIndex { get; set; }

        public PromotionCreative(string value, byte promoIndex = 1)
            : base(value)
        {
            PromoIndex = promoIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidatePromotionIndex(PromoIndex);

                return $"promo{PromoIndex}cr";
            }
        }
    }
}
