using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// Specifies the affiliation or store name.
    /// </summary>
    public class TransactionAffiliation : Parameter
    {
        public TransactionAffiliation(string value)
            : base(value)
        {
        }

        public override string Name => "ta";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Transaction};
    }
}
