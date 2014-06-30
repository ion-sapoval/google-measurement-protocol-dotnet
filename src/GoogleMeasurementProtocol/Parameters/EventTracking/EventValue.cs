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
                throw new ArgumentException("Values must be non-negative.","value");
            }
        }

        public override string Name
        {
            get { return "ev"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string>{HitTypes.Event}; }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }
}
