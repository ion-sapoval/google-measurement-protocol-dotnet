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
                throw new ArgumentException("Value must not be empty.","value");
            }
        }

        public override string Name
        {
            get { return "ea"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Event }; }
        }
    }
}
