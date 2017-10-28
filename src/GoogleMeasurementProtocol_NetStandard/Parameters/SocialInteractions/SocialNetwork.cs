using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.SocialInteractions
{
    /// <summary>
    /// Specifies the social network, for example Facebook or Google Plus.
    /// </summary>
    public class SocialNetwork : Parameter
    {
        public SocialNetwork(string value) : base(value)
        {
        }

        public override string Name => "sn";

        public override bool IsRequired => true;

        public override List<string> SupportedHitTypes => new List<string>{HitTypes.Social};
    }
}
