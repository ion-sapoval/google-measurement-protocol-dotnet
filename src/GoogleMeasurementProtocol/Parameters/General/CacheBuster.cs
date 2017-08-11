namespace GoogleMeasurementProtocol.Parameters.General
{
   /// <summary>
    /// Used to send a random number in GET requests to ensure browsers and proxies don't cache hits. 
    /// It should be sent as the final parameter of the request since we've seen some 3rd party internet filtering software add additional parameters to
    /// HTTP requests incorrectly. This value is not used in reporting.
   /// </summary>
    public class CacheBuster : Parameter
    {
        public CacheBuster(string value): base(value)
        {
        }

        public override string Name => "z";
    }
}
