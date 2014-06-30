using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.ECommerce
{
    /// <summary>
    /// Specifies the category that the item belongs to.
    /// </summary>
    public class ItemCategory : Parameter
    {
        public ItemCategory(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "iv"; }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Item }; }
        }
    }
}
