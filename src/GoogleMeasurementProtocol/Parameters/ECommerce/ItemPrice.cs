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

        public override string Name => "ip";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Item };

        public override Type ValueType => typeof(decimal);
    }
}
