using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// Specifies the SKU or item code.
    /// </summary>
    public class ItemCode : Parameter
    {
        public ItemCode(string value)
            : base(value)
        {
        }

        public override string Name => "ic";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Item };
    }
}
