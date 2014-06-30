namespace GoogleMeasurementProtocol.Parameters.CustomDimensions
{
   /// <summary>
    /// Each custom dimension has an associated index.
    /// There is a maximum of 20 custom dimensions (200 for Premium accounts).
    /// The name suffix must be a positive integer between 1 and 200, inclusive.
   /// </summary>
    public class CustomDimension : Parameter
    {
        public CustomDimension(string value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "cd[1-9][0-9]*"; }
        }
    }
}
