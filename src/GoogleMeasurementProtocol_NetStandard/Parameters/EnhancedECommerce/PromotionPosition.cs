using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The position of the creative.
    /// </summary>
    public class PromotionPosition : Parameter
    {
        public byte PromoIndex { get; set; }

        public PromotionPosition(string value, byte promoIndex = 1)
            : base(value)
        {
            PromoIndex = promoIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidatePromotionIndex(PromoIndex);

                return $"promo{PromoIndex}ps";
            }
        }
    }
}
