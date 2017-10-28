using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.EventTracking
{
    /// <summary>
    /// Specifies the event category. Must not be empty.
    /// </summary>
    public class EventCategory : Parameter
    {
        public EventCategory(string value)
            : base(value)
        {
        }

        public override string Name => "ec";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Event };
    }
}
