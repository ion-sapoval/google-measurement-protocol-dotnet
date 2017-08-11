namespace GoogleMeasurementProtocol.Parameters.ContentInformation
{
   /// <summary>
    /// The ID of a clicked DOM element, used to disambiguate multiple links to the same URL in In-Page Analytics
    /// reports when Enhanced Link Attribution is enabled for the property.
   /// </summary>
    public class LinkId : Parameter
    {
        public LinkId(string value)
            : base(value)
        {
        }

        public override string Name => "linkid";
    }
}
