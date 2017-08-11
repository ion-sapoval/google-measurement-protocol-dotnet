namespace GoogleMeasurementProtocol.Parameters.ContentInformation
{
    /// <summary>
    /// The title of the page / document.
    /// </summary>
    public class DocumentTitle : Parameter
    {
        public DocumentTitle(string value)
            : base(value)
        {
        }

        public override string Name => "dt";
    }
}
