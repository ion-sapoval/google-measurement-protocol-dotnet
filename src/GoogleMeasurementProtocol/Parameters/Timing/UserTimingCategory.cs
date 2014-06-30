using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
    /// <summary>
    /// Specifies the user timing category.
    /// </summary>
    public class UserTimingCategory : Parameter
    {
        public UserTimingCategory(string value) : base(value)
        {
        }

        public override string Name
        {
            get { return "utc"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string>{HitTypes.Timing}; }
        }
    }
}
