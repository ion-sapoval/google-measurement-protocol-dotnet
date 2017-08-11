namespace GoogleMeasurementProtocol.Parameters.Session
{
    /// <summary>
    /// The User Agent of the browser. Note that Google has libraries to identify real user agents.
    /// Hand crafting your own agent could break at any time.
    /// </summary>
    public class UserAgentOverride : Parameter
    {
        public UserAgentOverride(string value)
            : base(value)
        {
        }

        public override string Name => "ua";
    }
}
