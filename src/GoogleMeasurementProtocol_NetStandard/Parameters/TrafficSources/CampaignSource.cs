namespace GoogleMeasurementProtocol.Parameters.TrafficSources
{
    /// <summary>
    /// Specifies the campaign source.
    /// </summary>
    public class CampaignSource:Parameter
    {
        public CampaignSource(string value) : base(value)
        {
        }

        public override string Name => "cs";
    }
}
