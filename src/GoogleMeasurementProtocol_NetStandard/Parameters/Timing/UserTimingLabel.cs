using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
    /// <summary>
    /// Specifies the user timing label.
    /// </summary>
    public class UserTimingLabel : Parameter
    {
        public UserTimingLabel(string value)
            : base(value)
        {
        }

        public override string Name => "utl";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };
    }
}
