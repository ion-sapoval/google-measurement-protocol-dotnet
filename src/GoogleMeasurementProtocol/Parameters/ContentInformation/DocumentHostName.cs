namespace GoogleMeasurementProtocol.Parameters.ContentInformation
{
   /// <summary>
    /// Specifies the hostname from which content was hosted.
   /// </summary>
    public class DocumentHostName : Parameter
    {
        public DocumentHostName(string value)
            : base(value)
        {
        }

        public override string Name => "dh";
    }
}
