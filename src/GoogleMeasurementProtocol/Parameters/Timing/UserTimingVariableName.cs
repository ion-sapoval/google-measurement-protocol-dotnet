using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
   /// <summary>
    /// Specifies the user timing variable.
   /// </summary>
    public class UserTimingVariableName : Parameter
    {
        public UserTimingVariableName(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "utv"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Timing }; }
        }
    }
}
