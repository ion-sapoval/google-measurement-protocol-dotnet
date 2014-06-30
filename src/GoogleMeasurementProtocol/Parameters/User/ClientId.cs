using System;

namespace GoogleMeasurementProtocol.Parameters.User
{
    public class ClientId : Parameter
    {
        public ClientId(Guid value): base(value)
        {
        }

        public override string Name
        {
            get { return "cid"; }
        }

        public override Type ValueType
        {
            get { return typeof(Guid); }
        }
    }
}
