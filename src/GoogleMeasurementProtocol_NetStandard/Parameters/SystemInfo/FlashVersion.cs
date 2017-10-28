namespace GoogleMeasurementProtocol.Parameters.SystemInfo
{
    /// <summary>
    /// Specifies the flash version.Example value: 10 1 r103
    /// </summary>
    public class FlashVersion : Parameter
    {
        public FlashVersion(string value)
            : base(value)
        {
        }

        public override string Name => "fl";
    }
}
