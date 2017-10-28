using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.EventTracking
{
    /// <summary>
    /// Specifies the event action. Must not be empty.
    /// </summary>
    public class EventAction : Parameter
    {
        public EventAction(string value)
            : base(value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Value must not be empty.",nameof(value));
            }
        }

        public override string Name => "ea";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Event };
    }
}
