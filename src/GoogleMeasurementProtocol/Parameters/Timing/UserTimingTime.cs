using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
    /// <summary>
    /// Specifies the user timing value. The value is in milliseconds.
    /// </summary>
    public class UserTimingTime : Parameter
    {
        public UserTimingTime(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "utt"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Timing }; }
        }

        public override Type ValueType
        {
            get { return typeof (int); }
        }
    }
}
