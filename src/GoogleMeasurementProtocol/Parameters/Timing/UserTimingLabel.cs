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

        public override string Name
        {
            get { return "utl"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Timing }; }
        }
    }
}
