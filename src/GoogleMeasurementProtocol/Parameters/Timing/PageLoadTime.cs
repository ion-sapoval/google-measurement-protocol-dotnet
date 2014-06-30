using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
   /// <summary>
    /// Specifies the time it took for a page to load. The value is in milliseconds.
   /// </summary>
    public class PageLoadTime : Parameter
    {
        public PageLoadTime(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "plt"; }
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
