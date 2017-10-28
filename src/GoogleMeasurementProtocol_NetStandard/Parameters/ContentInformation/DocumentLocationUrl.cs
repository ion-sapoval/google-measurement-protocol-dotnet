namespace GoogleMeasurementProtocol.Parameters.ContentInformation
{
    /// <summary>
    /// Use this parameter to send the full URL (document location) of the page on which content resides.
    /// You can use the &dh and &dp parameters to override the hostname and path + query portions of the document location, accordingly.
    /// The JavaScript clients determine this parameter using the concatenation of the document.location.origin + document.location.pathname + document.location.search browser parameters.
    /// Be sure to remove any user authentication or other private information from the URL if present.
    /// </summary>
    public class DocumentLocationUrl : Parameter
    {
        public DocumentLocationUrl(string value)
            : base(value)
        {
        }

        public override string Name => "dl";
    }
}
