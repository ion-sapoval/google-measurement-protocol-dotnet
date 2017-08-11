using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
    /// <summary>
    /// Specifies the time it took for the DOMContentLoaded Event to fire. The value is in milliseconds.
    /// </summary>
    public class ContentLoadTime : Parameter
    {
        public ContentLoadTime(int value) : base(value)
        {
        }

        public override string Name => "clt";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };

        public override Type ValueType => typeof(int);
    }
}
