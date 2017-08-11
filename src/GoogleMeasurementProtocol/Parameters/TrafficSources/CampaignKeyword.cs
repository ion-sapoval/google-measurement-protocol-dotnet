namespace GoogleMeasurementProtocol.Parameters.TrafficSources
{
    /// <summary>
    /// Specifies the campaign keyword.
    /// </summary>
    public class CampaignKeyword : Parameter
    {
        public CampaignKeyword(string value)
            : base(value)
        {
        }

        public override string Name => "ck";
    }
}
