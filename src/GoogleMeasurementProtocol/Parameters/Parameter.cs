using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters
{
    public abstract class Parameter
    {
        protected Parameter(object value)
        {
            Value = value;
        }

        public abstract string Name { get; }

        public virtual Type ValueType => typeof (string);

        public object Value { get; set; }

        public virtual List<string> SupportedHitTypes => null;

        public virtual bool IsRequired => false;
    }
}
