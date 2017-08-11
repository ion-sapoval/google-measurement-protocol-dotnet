namespace GoogleMeasurementProtocol.Parameters.AppTracking
{
    /// <summary>
    /// Specifies the application version.
    /// </summary>
    public class ApplicationVersion : Parameter
    {
        public ApplicationVersion(string value)
            : base(value)
        {
        }

        public override string Name => "av";
    }
}
