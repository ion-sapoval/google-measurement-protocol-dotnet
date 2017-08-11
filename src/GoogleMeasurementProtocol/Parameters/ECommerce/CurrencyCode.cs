using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
   /// <summary>
    /// When present indicates the local currency for all transaction currency values. Value should be a valid ISO 4217 currency code.
   /// </summary>
    public class CurrencyCode : Parameter
    {
        public CurrencyCode(string value)
            : base(value)
        {
        }

        public override string Name => "cu";

       public override List<string> SupportedHitTypes => new List<string> { HitTypes.Transaction, HitTypes.Item };
    }
}
