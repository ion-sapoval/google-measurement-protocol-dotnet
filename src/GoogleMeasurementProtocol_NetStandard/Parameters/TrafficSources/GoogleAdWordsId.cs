namespace GoogleMeasurementProtocol.Parameters.TrafficSources
{
   /// <summary>
    /// Specifies the Google AdWords Id.
   /// </summary>
    public class GoogleAdWordsId : Parameter
    {
        public GoogleAdWordsId(string value)
            : base(value)
        {
        }

        public override string Name => "gclid";
    }
}
