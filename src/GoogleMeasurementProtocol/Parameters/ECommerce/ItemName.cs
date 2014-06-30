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

        public override string Name
        {
            get { return "in"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Item }; }
        }
    }
}
