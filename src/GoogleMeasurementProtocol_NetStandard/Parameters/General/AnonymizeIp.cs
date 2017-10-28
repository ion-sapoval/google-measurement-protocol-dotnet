using System;

namespace GoogleMeasurementProtocol.Parameters.General
{
    /// <summary>
    /// When present, the IP address of the sender will be anonymized. For example,
    /// the IP will be anonymized if any of the following parameters are present in the payload: &aip=, &aip=0, or &aip=1
    /// </summary>
    public class AnonymizeIp : Parameter
    {
        public AnonymizeIp(bool value) : base(value)
        {
        }

        public override string Name => "aip";

        public override Type ValueType => typeof (bool);
    }
}
