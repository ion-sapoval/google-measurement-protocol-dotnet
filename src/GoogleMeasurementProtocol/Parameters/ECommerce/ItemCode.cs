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

        public override string Name
        {
            get { return "ic"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Item }; }
        }
    }
}
