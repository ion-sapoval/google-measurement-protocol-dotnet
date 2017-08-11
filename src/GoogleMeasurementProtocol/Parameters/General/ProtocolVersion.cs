namespace GoogleMeasurementProtocol.Parameters.General
{
    /// <summary>
    /// The Protocol version. The current value is '1'. This will only change when there are changes made that are not backwards compatible.
    /// </summary>
    public class ProtocolVersion : Parameter
    {
        public ProtocolVersion(string value) : base(value)
        {
        }

        public override string Name => "v";

        public override bool IsRequired => true;
    }
}
