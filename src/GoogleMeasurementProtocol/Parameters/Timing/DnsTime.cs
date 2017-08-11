using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
   /// <summary>
    /// Specifies the time it took to do a DNS lookup.The value is in milliseconds.
   /// </summary>
    public class DnsTime : Parameter
    {
        public DnsTime(int value)
            : base(value)
        {
        }

        public override string Name => "dns";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };

        public override Type ValueType => typeof(int);
    }
}
