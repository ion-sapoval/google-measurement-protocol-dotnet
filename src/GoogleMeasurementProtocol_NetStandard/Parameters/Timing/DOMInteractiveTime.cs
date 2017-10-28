using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
    /// <summary>
    /// Specifies the time it took for Document.readyState to be 'interactive'. The value is in milliseconds.
    /// </summary>
    public class DOMInteractiveTime : Parameter
    {
        public DOMInteractiveTime(int value) : base(value)
        {
        }

        public override string Name => "dit";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };

        public override Type ValueType => typeof(int);
    }
}
