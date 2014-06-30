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

        public override string Name
        {
            get { return "tcp"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Timing }; }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }
}
