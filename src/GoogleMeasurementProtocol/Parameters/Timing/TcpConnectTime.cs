using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
    /// <summary>
    /// Specifies the time it took for a TCP connection to be made. The value is in milliseconds.
    /// </summary>
    public class TcpConnectTime : Parameter
    {
        public TcpConnectTime(int value)
            : base(value)
        {
        }

        public override string Name => "tcp";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };

        public override Type ValueType => typeof(int);
    }
}
