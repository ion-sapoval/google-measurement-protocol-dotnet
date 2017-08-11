namespace GoogleMeasurementProtocol.Parameters.AppTracking
{
   /// <summary>
    /// Application installer identifier.
   /// </summary>
    public class ApplicationInstallerId : Parameter
    {
        public ApplicationInstallerId(string value)
            : base(value)
        {
        }

        public override string Name => "aiid";
    }
}
