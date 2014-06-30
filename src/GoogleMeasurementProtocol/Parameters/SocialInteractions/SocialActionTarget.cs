using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.SocialInteractions
{
   /// <summary>
    /// Specifies the target of a social interaction. This value is typically a URL but can be any text.
   /// </summary>
    public class SocialActionTarget : Parameter
    {
        public SocialActionTarget(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "st"; }
        }

        public override bool IsRequired
        {
            get
            {
                return true;
            }
        }

        public override List<string> SupportedHitTypes
        {
            get { return new List<string> { HitTypes.Social }; }
        }
    }
}
