namespace GoogleMeasurementProtocol.Parameters.Session
{
    /// <summary>
    /// The IP address of the user. This should be a valid IP address.
    /// It will always be anonymized just as though &aip (anonymize IP) had been used.
    /// </summary>
    public class IpOverride : Parameter
    {
        public IpOverride(string value) : base(value)
        {
        }

        public override string Name => "uip";
    }
}
