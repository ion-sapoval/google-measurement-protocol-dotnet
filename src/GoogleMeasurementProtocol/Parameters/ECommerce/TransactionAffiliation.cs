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

        public override string Name
        {
            get { return "ta"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Transaction}; }
        }
    }
}
