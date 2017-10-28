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

        public override string Name => "utv";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };
    }
}
