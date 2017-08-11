using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// Specifies the item name.
    /// </summary>
    public class ItemName : Parameter
    {
        public ItemName(string value)
            : base(value)
        {
        }

        public override string Name => "in";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Item };
    }
}
