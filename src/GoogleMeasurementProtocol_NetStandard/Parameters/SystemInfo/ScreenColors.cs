namespace GoogleMeasurementProtocol.Parameters.SystemInfo
{
    /// <summary>
    /// Specifies the screen color depth.Example value: 24-bits
    /// </summary>
    public class ScreenColors : Parameter
    {
        public ScreenColors(string value)
            : base(value)
        {
        }

        public override string Name => "sd";
    }
}
