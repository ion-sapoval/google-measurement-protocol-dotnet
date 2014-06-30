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

        public override string Name
        {
            get { return "sn"; }
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
            get { return new List<string>{HitTypes.Social}; }
        }
    }
}
