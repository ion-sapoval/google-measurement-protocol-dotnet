using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
   /// <summary>
    /// Specifies the time it took for the server to respond after the connect time. The value is in milliseconds.
   /// </summary>
    public class ServerResponseTime : Parameter
    {
        public ServerResponseTime(int value)
            : base(value)
        {
        }

        public override string Name => "srt";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };

        public override Type ValueType => typeof(int);
    }
}
