namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// Additional information about a checkout step. This is an additional parameter that can be sent when Product Action is set to 'checkout'.
   /// </summary>
    public class CheckoutStepOption : Parameter
    {
        public CheckoutStepOption(string value)
            : base(value)
        {
        }

        public override string Name => @"col";
    }
}
