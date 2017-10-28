namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The transaction ID. This is an additional parameter that can be sent when Product Action is set to 'purchase' or 'refund'.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class TransactionId : Parameter
    {
        public TransactionId(string value)
            : base(value)
        {
        }

        public override string Name => @"ti";
    }
}
