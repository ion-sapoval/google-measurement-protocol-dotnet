namespace GoogleMeasurementProtocol.Parameters.AppTracking
{
    /// <summary>
    /// Application identifier.
    /// </summary>
    public class ApplicationId : Parameter
    {
        public ApplicationId(string value)
            : base(value)
        {
        }

        public override string Name => "aid";
    }
}
