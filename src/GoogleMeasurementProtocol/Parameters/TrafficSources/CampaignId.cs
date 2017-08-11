namespace GoogleMeasurementProtocol.Parameters.TrafficSources
{
    /// <summary>
    /// Specifies the campaign ID.
    /// </summary>
    public class CampaignId : Parameter
    {
        public CampaignId(string value)
            : base(value)
        {
        }

        public override string Name => "ci";
    }
}
