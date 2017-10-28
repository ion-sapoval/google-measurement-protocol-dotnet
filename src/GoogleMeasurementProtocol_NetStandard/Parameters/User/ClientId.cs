using System;

namespace GoogleMeasurementProtocol.Parameters.User
{
    public class ClientId : Parameter
    {
        public ClientId(Guid value): base(value)
        {
        }

        public ClientId(string value) : base(value)
        {
        }

        public override string Name => "cid";

        public override Type ValueType => Value.GetType();
    }
}
