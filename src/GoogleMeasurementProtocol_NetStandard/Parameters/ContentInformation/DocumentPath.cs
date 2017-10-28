namespace GoogleMeasurementProtocol.Parameters.ContentInformation
{
   /// <summary>
    /// The path portion of the page URL. Should begin with '/'.
   /// </summary>
    public class DocumentPath : Parameter
    {
        public DocumentPath(string value)
            : base(value)
        {
        }

        public override string Name => "dp";
    }
}
