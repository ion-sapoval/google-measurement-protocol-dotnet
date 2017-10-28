namespace GoogleMeasurementProtocol.Parameters.SystemInfo
{
    /// <summary>
    /// Specifies the viewable area of the browser / device.Example value: 123x456
    /// </summary>
    public class ViewportSize : Parameter
    {
        public ViewportSize(string value)
            : base(value)
        {
        }

        public override string Name => "vp";
    }
}
