using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMeasurementProtocol.Parameters
{
    public abstract class Parameter
    {
        protected Parameter(object value)
        {
            Value = value;
        }
        public abstract string Name { get; }

        public virtual Type ValueType
        {
            get { return typeof (string); }
        }

        public object Value { get; set; }

        public virtual List<string> SupportedHitTypes
        {
            get { return null; }
        }

        public virtual bool IsRequired
        {
            get { return false; }
        }
    }
}
