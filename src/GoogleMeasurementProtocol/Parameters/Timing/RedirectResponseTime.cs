using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
    /// <summary>
    /// Specifies the time it took for any redirects to happen. The value is in milliseconds.
    /// </summary>
    public class RedirectResponseTime : Parameter
    {
        public RedirectResponseTime(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "rrt"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Timing }; }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }
}
