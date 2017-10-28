namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The store or affiliation from which this transaction occurred.
    /// This is an additional parameter that can be sent when Product Action is set to 'purchase' or 'refund'.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
   /// </summary>
    public class Affiliation : Parameter
    {
        public Affiliation(string value)
            : base(value)
        {
        }

        public override string Name => @"ta";
    }
}
