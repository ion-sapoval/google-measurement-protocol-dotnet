namespace GoogleMeasurementProtocol.Parameters.TrafficSources
{
    /// <summary>
    /// Specifies the campaign name.
    /// </summary>
    public class CampaignName : Parameter
    {
        public CampaignName(string value) : base(value)
        {
        }

        public override string Name => "cn";
    }
}
