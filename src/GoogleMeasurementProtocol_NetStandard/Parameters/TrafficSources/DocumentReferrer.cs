namespace GoogleMeasurementProtocol.Parameters.TrafficSources
{
    /// <summary>
    /// Specifies which referral source brought traffic to a website.
    /// This value is also used to compute the traffic source. The format of this value is a URL.
    /// </summary>
    public class DocumentReferrer : Parameter
    {
        public DocumentReferrer(string value) : base(value)
        {
        }

        public override string Name => "dr";
    }
}
