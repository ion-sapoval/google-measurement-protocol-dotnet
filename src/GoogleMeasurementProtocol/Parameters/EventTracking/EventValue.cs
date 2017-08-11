using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.EventTracking
{
    /// <summary>
    /// Specifies the event value. Values must be non-negative.
    /// </summary>
    public class EventValue : Parameter
    {
        public EventValue(int value)
            : base(value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Values must be non-negative.",nameof(value));
            }
        }

        public override string Name => "ev";

        public override List<string> SupportedHitTypes => new List<string>{HitTypes.Event};

        public override Type ValueType => typeof(int);
    }
}
