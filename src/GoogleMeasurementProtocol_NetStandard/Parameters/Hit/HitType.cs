namespace GoogleMeasurementProtocol.Parameters.Hit
{
    /// <summary>
    /// The type of hit. Must be one of 'pageview', 'screenview', 'event', 'transaction', 'item', 'social', 'exception', 'timing'.
    /// </summary>
    public class HitType: Parameter
    {
        public HitType(string value) : base(value)
        {
        }

        public override string Name => "t";

        public override bool IsRequired => true;
    }
}
