namespace GoogleMeasurementProtocol.Parameters.TrafficSources
{
    /// <summary>
    /// Specifies the campaign content.
    /// </summary>
    public class CampaignContent : Parameter
    {
        public CampaignContent(string value)
            : base(value)
        {
        }

        public override string Name => "cc";
    }
}
