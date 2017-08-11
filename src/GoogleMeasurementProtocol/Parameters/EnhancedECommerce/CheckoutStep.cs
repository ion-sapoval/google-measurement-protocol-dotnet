using System;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The step number in a checkout funnel. This is an additional parameter that can be sent when Product Action is set to 'checkout'. 
   /// </summary>
    public class CheckoutStep : Parameter
    {
        public CheckoutStep(int value)
            : base(value)
        {
        }

        public override string Name => "cos";

       public override Type ValueType => typeof(int);
    }
}
