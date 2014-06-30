using System;

namespace GoogleMeasurementProtocol.Parameters.SystemInfo
{
    /// <summary>
    /// Specifies whether Java was enabled.
    /// </summary>
    public class JavaEnabled : Parameter
    {
        public JavaEnabled(bool value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "je"; }
        }

        public override Type ValueType
        {
            get { return typeof(bool); }
        }
    }
}
