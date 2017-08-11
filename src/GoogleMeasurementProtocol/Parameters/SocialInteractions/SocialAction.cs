using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.SocialInteractions
{
   /// <summary>
    /// Specifies the social interaction action.
    /// For example on Google Plus when a user clicks the +1 button, the social action is 'plus'.
   /// </summary>
    public class SocialAction : Parameter
    {
        public SocialAction(string value)
            : base(value)
        {
        }

        public override string Name => "sa";

        public override bool IsRequired => true;

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Social };
    }
}
