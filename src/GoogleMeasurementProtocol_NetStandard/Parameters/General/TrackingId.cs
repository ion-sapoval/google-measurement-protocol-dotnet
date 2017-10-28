namespace GoogleMeasurementProtocol.Parameters.General
{
    /// <summary>
    /// he tracking ID / web property ID. The format is UA-XXXX-Y. All collected data is associated by this ID.
    /// </summary>
    public class TrackingId : Parameter
    {
        public TrackingId(string value) : base(value)
        {
        }

        public override string Name => "tid";

        public override bool IsRequired => true;
    }
}
