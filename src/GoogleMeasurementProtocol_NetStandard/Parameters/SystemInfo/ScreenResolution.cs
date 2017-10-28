namespace GoogleMeasurementProtocol.Parameters.SystemInfo
{
    /// <summary>
    /// Specifies the screen resolution.Example value: 800x600
    /// </summary>
    public class ScreenResolution : Parameter
    {
        public ScreenResolution(string value) : base(value)
        {
        }

        public override string Name => "sr";
    }
}
