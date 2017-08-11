using System.Collections.Generic;
namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// A unique identifier for the transaction. 
    /// This value should be the same for both the Transaction hit and Items hits associated to the particular transaction.
    /// </summary>
    public class TransactionId : Parameter
    {
        public TransactionId(string value) : base(value)
        {
        }

        public override string Name => "ti";

        public override bool IsRequired => true;

        public override List<string> SupportedHitTypes => new List<string>{HitTypes.Transaction, HitTypes.Item};
    }
}
