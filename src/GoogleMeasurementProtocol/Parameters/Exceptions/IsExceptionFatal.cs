using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Exceptions
{
    /// <summary>
    /// Specifies whether the exception was fatal.
    /// </summary>
    public class IsExceptionFatal : Parameter
    {
        public IsExceptionFatal(bool value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "exf"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Exception }; }
        }

        public override Type ValueType
        {
            get { return typeof(bool); }
        }
    }
}
