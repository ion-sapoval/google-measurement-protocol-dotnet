using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// Specifies the number of items purchased.
    /// </summary>
    public class ItemQuantity : Parameter
    {
        public ItemQuantity(int value)
            : base(value)
        {
        }

        public override string Name => "iq";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Item };

        public override Type ValueType => typeof(int);
    }
}
