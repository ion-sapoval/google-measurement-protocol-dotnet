namespace GoogleMeasurementProtocol.Parameters.Session
{
    /// <summary>
    /// The geographical location of the user. 
    /// The geographical ID should be a two letter country code or a criteria ID representing a city or region (see http://developers.google.com/analytics/devguides/collection/protocol/v1/geoid).
    /// This parameter takes precedent over any location derived from IP address, including the IP Override parameter. 
    /// An invalid code will result in geographical dimensions to be set to '(not set)'.
    /// </summary>
    public class GeographicalOverride : Parameter
    {
        public GeographicalOverride(string value) : base(value)
        {
        }

        public override string Name => "geoid";
    }
}
