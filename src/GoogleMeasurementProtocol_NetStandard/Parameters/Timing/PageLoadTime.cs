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

        public override string Name => "plt";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };

        public override Type ValueType => typeof(int);
    }
}
