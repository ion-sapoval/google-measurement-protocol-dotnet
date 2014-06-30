using System;

namespace GoogleMeasurementProtocol.Parameters.Hit
{
   /// <summary>
    /// Specifies that a hit be considered non-interactive.
   /// </summary>
    public class NonInteractionHit : Parameter
    {
        public NonInteractionHit(bool value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "ni"; }
        }

        public override Type ValueType
        {
            get { return typeof(bool); }
        }
    }
}
