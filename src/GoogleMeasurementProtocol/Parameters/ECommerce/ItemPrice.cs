using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// Specifies the price for a single item / unit.
    /// </summary>
    public class ItemPrice : Parameter
    {
        public ItemPrice(decimal value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "ip"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Item }; }

        }

        public override Type ValueType
        {
            get
            {
                return typeof(decimal);
            }
        }
    }
}
